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
    public class DepartmentController : GenericController<DepartmentLib, DepartmentReqDTO, DepartmentResDTO>
    {
        public DepartmentController(IDepartmentRepository repo, IMapper mapper, ILogger<GenericController<DepartmentLib, DepartmentReqDTO, DepartmentResDTO>> logger) : base(repo, mapper, logger)
        {
        }
    }
}