using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QCService.DTOs.Requests;
using QCService.DTOs.Responses;
using QCService.Infrastructure.Services;
using QCService.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCService.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class QCRequestController : ControllerBase
    {
        private readonly IQCRequestService _service;
        private readonly IMapper _mapper;
        private readonly ILogger<OldQCTicketController> _logger;

        public QCRequestController(IQCRequestService service, IMapper mapper, ILogger<OldQCTicketController> logger)
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QCTicketDTO>>> FindQCTicket([FromQuery] QCRequestFilterReqDTO filter)
        {
            var data = await _service.FindQCTicketAsync(filter);
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<QCTicketDTO>>> GetQCTicket(Guid id)
        {
            var data = await _service.GetQCTicketAsync(id);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable<QCTicketDTO>>> DeleteQCTicket(Guid id)
        {
            var data = await _service.DeleteQCTicketAsync(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<QCTicketDTO>>> AddOrUpdateQCTicketAsync(QCTicketDTO qCTicket)
        {
            var data = await _service.AddOrUpdateQCTicketAsync(qCTicket);
            return Ok(data);
        }

    }
}
