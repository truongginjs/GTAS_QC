using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QCService.DTOs.Requests;
using QCService.DTOs.Responses;
using QCService.Infrastructure.Services;

namespace QCService.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class OldQCTicketController : ControllerBase
    {
        private readonly IQCRequestService _service;
        private readonly IMapper _mapper;
        private readonly ILogger<OldQCTicketController> _logger;

        public OldQCTicketController(IQCRequestService service, IMapper mapper, ILogger<OldQCTicketController> logger)
        {
            _service = service;
            _mapper = mapper;
            _logger = logger;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QCRequestResDTO>>> FindFromStorage([FromQuery] QCRequestFilterReqDTO filter)
        {
            var data = await _service.FindQCRequestInStorageAsync(filter);
            _logger.LogInformation("find from storage");
            return Ok(data);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QCRequestResDTO>>> FindFromWfx([FromQuery] QCRequestFilterReqDTO filter)
        {
            var data = await _service.FindQCRequestFromWFXAsync(filter);
            _logger.LogInformation("find from Wfx");
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<QCDetailResDTO>> GetAsync(Guid id)
        {
            var data = await _service.GetAsync(id);
            if (data == null) return NotFound();
            var result = _mapper.Map<QCDetailResDTO>(data);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<QCDetailResDTO>> CreateAsync([FromBody] QCRequestCreateResDTO input)
        {
            var data = await _service.CreateAsync(input);
            if (data == null) return BadRequest();
            var result = _mapper.Map<QCDetailResDTO>(data);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<QCDetailResDTO>> UpdateAsync(Guid id, [FromBody] QCRequestUpdateReqDTO input)
        {
            input.Id = id;
            var data = await _service.UpdateAsync(input);
            if (data == null) return BadRequest();
            var result = _mapper.Map<QCDetailResDTO>(data);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<QCDetailResDTO>> DateleAsync(Guid id)
        {
            var data = await _service.DeleteAsync(id);
            if (data == null) return BadRequest();
            var result = _mapper.Map<QCDetailResDTO>(data);
            return Ok(result);
        }

    }
}