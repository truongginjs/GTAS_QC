using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QCService.DTOs.Requests;
using QCService.DTOs.Responses;
using QCService.Infrastructure.Repositories;
using QCService.Models;

namespace QCService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QCTicketController : ControllerBase
    {
        private readonly IQCTicketRepository _repo;
        private readonly IMapper _mapper;
        private readonly ILogger<QCTicketController> _logger;

        public QCTicketController(IQCTicketRepository repo, IMapper mapper, ILogger<QCTicketController> logger)
        {
            _repo = repo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QCTicketResDTO>>> GetsAsync()
        {
            var data = await _repo.GetsAsync();
            var result = _mapper.Map<IEnumerable<QCTicketResDTO>>(data);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<QCTicketResDTO>> GetAsync(Guid id)
        {
            var data = await _repo.GetAsync(id);
            if (data == null) return NotFound();
            var result = _mapper.Map<QCTicketResDTO>(data);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<QCTicketResDTO>> CreateAsync([FromBody] QCTicketReqDTO test)
        {
            var input = _mapper.Map<QCTicket>(test);
            var data = await _repo.CreateAsync(input);
            if (data == null) return BadRequest();
            var result = _mapper.Map<QCTicketResDTO>(data);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<QCTicketResDTO>> UpdateAsync(Guid id, [FromBody] QCTicketReqDTO test)
        {
            var input = _mapper.Map<QCTicket>(test);
            var data = await _repo.UpdateAsync(id, input);
            if (data == null) return BadRequest();
            var result = _mapper.Map<QCTicketResDTO>(data);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<QCTicketResDTO>> UpdateAsync(Guid id)
        {
            var data = await _repo.DeleteAsync(id);
            if (data == null) return BadRequest();
            var result = _mapper.Map<QCTicketResDTO>(data);
            return Ok(result);
        }

    }
}