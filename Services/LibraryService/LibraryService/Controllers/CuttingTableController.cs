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
    public class CuttingTableController : GenericController<CuttingTableLib, CuttingTableReqDTO, CuttingTableResDTO>
    {
        public CuttingTableController(ICuttingTableRepository repo, IMapper mapper, ILogger<GenericController<CuttingTableLib, CuttingTableReqDTO, CuttingTableResDTO>> logger) : base(repo, mapper, logger)
        {
        }
    }
}