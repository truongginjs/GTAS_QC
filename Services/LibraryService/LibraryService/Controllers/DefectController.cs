using AutoMapper;
using LibraryService.DTOs.Requests;
using LibraryService.DTOs.Responses;
using LibraryService.Infrastructure.Repositories;
using LibraryService.Models.L01;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryService.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DefectController : GenericController<DefectLib, DefectReqDTO, DefectResDTO>
    {
        private readonly IDefectRepository _repo;
        private readonly IMapper _mapper;

        public DefectController(IDefectRepository repo, IMapper mapper, ILogger<GenericController<DefectLib, DefectReqDTO, DefectResDTO>> logger) : base(repo, mapper, logger)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("showall")]
        public virtual async Task<ActionResult<IEnumerable<DefectsInfoResDTO>>> ShowAllAsync()
        {
            var data = await _repo.GetsInfoAsync();
            var result = _mapper.Map<IEnumerable<DefectsInfoResDTO>>(data);
            return Ok(result);
        }

        [HttpGet("byZoneType/{id}")]
        public virtual async Task<ActionResult<IEnumerable<DefectsInfoResDTO>>> ShowAllAsync(Guid id)
        {
            var data = await _repo.InvokeAsync(context=>context.Set<DefectLib>().Where(x=>x.ZoneTypeId==id).ToListAsync());
            var result = _mapper.Map<IEnumerable<DefectResDTO>>(data);
            return Ok(result);
        }

        //[HttpGet("detail")]
        //public virtual async Task<ActionResult<IEnumerable<DefectLib>>> Detail()
        //{
        //    var data = await _repo.GetsAsync();
        //    //var result = _mapper.Map<IEnumerable<DefectResDTO>>(data);
        //    return Ok(data);
        //}
    }
}
