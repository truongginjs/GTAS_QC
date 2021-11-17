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
    public class HandlerDefectController : GenericController<HandlerDefectLib, HandlerDefectReqDTO, HandlerDefectResDTO>
    {
        public HandlerDefectController(IHandlerDefectRepository repo, IMapper mapper, ILogger<GenericController<HandlerDefectLib, HandlerDefectReqDTO, HandlerDefectResDTO>> logger) : base(repo, mapper, logger)
        {
        }
    }
}