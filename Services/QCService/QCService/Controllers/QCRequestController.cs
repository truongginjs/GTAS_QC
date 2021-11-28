using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QCService.DTOs.Requests;
using QCService.DTOs.Responses;
using QCService.Infrastructure.Services;
using QCService.Models.D01;
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
        public async Task<ActionResult<IEnumerable<QCRequestResDTO>>> FindFromWfx([FromQuery] QCRequestFilterReqDTO filter)
        {
            var data = await _service.FindQCRequestFromWFXAsync(filter);
            _logger.LogInformation("find from Wfx");
            return Ok(data);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QCRequestResDTO>>> FindQCRequest([FromQuery] QCRequestListReqDTO filter)
        {
            try
            {
                var data = await _service.FindQCRequestAsync(filter);
                var result = _mapper.Map<IEnumerable<QCRequestResDTO>>(data);
                if (result is null)
                { return NoContent(); }
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<QCRequestDetailResDTO>> GetQCRequest(Guid id)
        {
            try
            {
                var data = await _service.GetQCRequestAsync(id);
                var result = _mapper.Map<QCRequestDetailResDTO>(data);
                if (result is null)
                { return NoContent(); }
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<QCRequestDetailResDTO>> DeleteQCRequest(Guid id)
        {
            try
            {
                var data = await _service.DeleteQCRequestAsync(id);
                var result = _mapper.Map<QCRequestDetailResDTO>(data);
                if (result is null)
                { return NoContent(); }
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        public async Task<ActionResult<QCRequestDetailResDTO>> AddOrUpdateQCRequestAsync(QCRequestDetailReqDTO qCRequestDetail)
        {
            try
            {
                var qCRequestDetailDB = _mapper.Map<QCRequestDetailReqDBDTO>(qCRequestDetail);
                var data = await _service.AddOrUpdateQCRequestAsync(qCRequestDetailDB);
                var result = _mapper.Map<QCRequestDetailResDTO>(data);
                if (result is null)
                { return NoContent(); }
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        //[HttpPut("{id}")]
        //public async Task<ActionResult<QCRequestDetailResDTO>> ApproveQCRequest(Guid id)
        //{
        //    try
        //    {
        //        //var data = await _service.DeleteQCRequestAsync(id);
        //        //var result = _mapper.Map<QCRequestDetailResDTO>(data);
        //        if (result is null)
        //        { return NoContent(); }
        //        return Ok(result);
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e);
        //    }
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QCRequestResDTO>>> SearchQCRequest([FromQuery] FindQCRequestReqDTO filter)
        {
            try
            {
                var data = await _service.SearchQCRequestAsync(filter);
                var result = _mapper.Map<IEnumerable<QCRequestResDTO>>(data);
                if (result is null)
                { return NoContent(); }
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
