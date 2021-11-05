using AutoMapper;
using LibraryService.DTOs.Requests;
using LibraryService.DTOs.Responses;
using LibraryService.Infrastructure.Repositories;
using LibraryService.Models.L01;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SINNIKA.EFCore.Initialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class AQLController : GenericController<AQLLib, AQLReqDTO, AQLResDTO>
    {
        public AQLController(IAQLRepository repo, IMapper mapper, ILogger<GenericController<AQLLib, AQLReqDTO, AQLResDTO>> logger) : base(repo, mapper, logger)
        {
        }
    }
}
