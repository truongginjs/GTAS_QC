using AutoMapper;
using LibraryService.DTOs.Requests;
using LibraryService.DTOs.Responses;
using LibraryService.Infrastructure.Repositories;
using LibraryService.Models.L01;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryService.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TimeLineDefectController : GenericController<TimelineDefectLib, TimelineDefectReqDTO, TimelineDefectResDTO>
    {
        private readonly ITimeDefectRepository _repo;
        private readonly IMapper _mapper;


        public TimeLineDefectController(ITimeDefectRepository repo, IMapper mapper, ILogger<GenericController<TimelineDefectLib, TimelineDefectReqDTO, TimelineDefectResDTO>> logger) : base(repo, mapper, logger)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("showall")]
        public virtual async Task<ActionResult<IEnumerable<TimelineDefectInfoResDTO>>> ShowAllAsync()
        {
            var data = await _repo.GetsInfoAsync();
            var result = _mapper.Map<IEnumerable<TimelineDefectInfoResDTO>>(data);
            return Ok(result);
        }
    }
}