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
    public class DefectController : GenericController<DefectLib, DefectReqDTO, DefectResDTO>
    {
        public DefectController(IDefectRepository repo, IMapper mapper, ILogger<GenericController<DefectLib, DefectReqDTO, DefectResDTO>> logger) : base(repo, mapper, logger)
        {
        }
    }
}
