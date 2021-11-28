using AutoMapper;
using LibraryService.DTOs.Requests;
using LibraryService.DTOs.Responses;
using LibraryService.Infrastructure.Repositories;
using LibraryService.Models.L01;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LibraryService.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TimeLineDefectController : GenericController<TimelineDefectLib, TimelineDefectReqDTO, TimelineDefectResDTO>
    {
        public TimeLineDefectController(ITimeDefectRepository repo, IMapper mapper, ILogger<GenericController<TimelineDefectLib, TimelineDefectReqDTO, TimelineDefectResDTO>> logger) : base(repo, mapper, logger)
        {
        }
    }
}