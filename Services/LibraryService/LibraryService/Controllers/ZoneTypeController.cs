using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LibraryService.DTOs;
using LibraryService.Infrastructure.Repositories;
using LibraryService.Models;
using LibraryService.Infrastructure.Repositories.Imps;
using Microsoft.AspNetCore.Authorization;

namespace LibraryService.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ZoneTypeController : ControllerBase
    {
        private readonly IZoneTypeRepository _repo;
        private readonly IMapper _mapper;
        private readonly ILogger<ZoneTypeController> _logger;

        public ZoneTypeController(IZoneTypeRepository repo, IMapper mapper, ILogger<ZoneTypeController> logger)
        {
            _repo = repo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ZoneTypeResponseDTO>>> GetsAsync()
        {
            var data = await _repo.GetsAsync();
            var result = _mapper.Map<IEnumerable<ZoneTypeResponseDTO>>(data);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ZoneTypeResponseDTO>> GetAsync(Guid id)
        {
            var data = await _repo.GetAsync(id);
            if (data == null) return NotFound();
            var result = _mapper.Map<ZoneTypeResponseDTO>(data);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ZoneTypeResponseDTO>> CreateAsync([FromBody] ZoneTypeRequestDTO test)
        {
            var input = _mapper.Map<ZoneType>(test);
            var data = await _repo.CreateAsync(input);
            if (data == null) return BadRequest();
            var result = _mapper.Map<ZoneTypeResponseDTO>(data);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ZoneTypeResponseDTO>> UpdateAsync(Guid id, [FromBody] ZoneTypeRequestDTO test)
        {
            var input = _mapper.Map<ZoneType>(test);
            var data = await _repo.UpdateAsync(id, input);
            if (data == null) return BadRequest();
            var result = _mapper.Map<ZoneTypeResponseDTO>(data);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ZoneTypeResponseDTO>> UpdateAsync(Guid id)
        {
            var data = await _repo.DeleteAsync(id);
            if (data == null) return BadRequest();
            var result = _mapper.Map<ZoneTypeResponseDTO>(data);
            return Ok(result);
        }

    }
}