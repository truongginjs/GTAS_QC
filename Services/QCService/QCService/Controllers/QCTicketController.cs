using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QCService.DTOs.Requests;
using QCService.DTOs.Responses;
using QCService.Infrastructure.Repositories;
using QCService.Infrastructure.Services;
using QCService.Models;
using QCService.Models.D01;

namespace QCService.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class QCTicketController : ControllerBase
    {
        private readonly IQCTicketService _service;
        private readonly IMapper _mapper;
        private readonly ILogger<QCTicketController> _logger;

        public QCTicketController(IQCTicketService service, IMapper mapper, ILogger<QCTicketController> logger)
        {
            _service = service;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QCRequestResDTO>>> FindFromStorage(QCRequestFilterReqDTO filter)
        {
            var data = await _service.FindQCRequestInStorageAsync(filter);
            _logger.LogInformation("find from storage");
            return Ok(data);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QCRequestResDTO>>> FindFromWfx(QCRequestFilterReqDTO filter)
        {
            var data = await _service.FindQCRequestFromWFXAsync(filter);
            _logger.LogInformation("find from Wfx");
            return Ok(data);
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<QCTicketResDTO>> GetAsync(Guid id)
        {
            var data = await _service.GetAsync(id);
            if (data == null) return NotFound();
            var result = _mapper.Map<QCTicketResDTO>(data);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<QCTicketResDTO>> CreateAsync([FromBody] QCRequestCreateResDTO input)
        {
            var data = await _service.CreateAsync(input);
            if (data == null) return BadRequest();
            var result = _mapper.Map<QCTicketResDTO>(data);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<QCTicketResDTO>> UpdateAsync(Guid id, [FromBody] QCRequestUpdateResDTO input)
        {
            input.Id = id;
            var data = await _service.UpdateAsync(input);
            if (data == null) return BadRequest();
            var result = _mapper.Map<QCTicketResDTO>(data);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<QCTicketResDTO>> DateleAsync(Guid id)
        {
            var data = await _service.DeleteAsync(id);
            if (data == null) return BadRequest();
            var result = _mapper.Map<QCTicketResDTO>(data);
            return Ok(result);
        }

    }
}