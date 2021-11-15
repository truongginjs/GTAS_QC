using AutoMapper;
using LibraryService.Infrastructure.Repositories;
using LibraryService.Models.L01;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LibraryService.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TimeDefectController : GenericController<TimeDefectLib, TimeDefectReqDTO, TimeDefectResDTO>
    {
        public TimeDefectController(ITimeDefectRepository repo, IMapper mapper, ILogger<GenericController<TimeDefectLib, TimeDefectReqDTO, TimeDefectResDTO>> logger) : base(repo, mapper, logger)
        {
        }
    }
}