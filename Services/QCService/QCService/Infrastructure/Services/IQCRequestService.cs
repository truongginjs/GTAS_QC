using QCService.DTOs.Requests;
using QCService.Models.D01;
using QCService.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCService.Infrastructure.Services
{
    public interface IQCRequestService
    {
        public Task<QCDetail> GetAsync(Guid id);
        public Task<List<QCRequest>> FindQCRequestInStorageAsync(QCRequestFilterReqDTO filter);
        public Task<List<QCRequest>> FindQCRequestFromWFXAsync(QCRequestFilterReqDTO filter);
        public Task<List<QCTicketDTO>> FindQCTicketAsync(QCRequestFilterReqDTO filter);
        public Task<QCTicketDTO> GetQCTicketAsync(Guid Id);
        public Task<QCTicketDTO> DeleteQCTicketAsync(Guid Id);
        public Task<QCTicketDTO> AddOrUpdateQCTicketAsync(QCTicketDTO qCTicket);
        public Task<QCRequest> CreateAsync(QCRequestCreateResDTO qc);
        public Task<QCRequest> UpdateAsync(QCRequestUpdateReqDTO qc);
        Task<QCRequest> DeleteAsync(Guid id);
    }
}
