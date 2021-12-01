using AutoMapper;
using LibraryService.DTOs.Requests;
using LibraryService.DTOs.Responses;
using LibraryService.Infrastructure.Repositories;
using LibraryService.Models.L01;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryService.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class HandlerDefectController : GenericController<HandlerDefectLib, HandlerDefectReqDTO, HandlerDefectResDTO>
    {
        private readonly IHandlerDefectRepository _repo;
        private readonly IMapper _mapper;
        public HandlerDefectController(IHandlerDefectRepository repo, IMapper mapper, ILogger<GenericController<HandlerDefectLib, HandlerDefectReqDTO, HandlerDefectResDTO>> logger) : base(repo, mapper, logger)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("showall")]
        public virtual async Task<ActionResult<IEnumerable<HandlerDefectInfoResDTO>>> ShowAllAsync()
        {
            try
            {

            var data = await _repo.GetsInfoAsync();
            var result = _mapper.Map<IEnumerable<HandlerDefectInfoResDTO>>(data);
            return Ok(result);
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}