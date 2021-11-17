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
    public class SiteController : GenericController<SiteLib, SiteReqDTO, SiteResDTO>
    {
        public SiteController(ISiteRepository repo, IMapper mapper, ILogger<GenericController<SiteLib, SiteReqDTO, SiteResDTO>> logger) : base(repo, mapper, logger)
        {
        }
    }
}