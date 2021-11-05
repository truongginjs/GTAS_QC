using QCService.DTOs.Requests;
using QCService.Models.D01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCService.Infrastructure.Services
{
    public interface IQCTicketService
    {
        public Task<QCTicket> GetAsync(Guid id);
        public Task<List<QCRequest>> FindQCRequestInStorageAsync(QCRequestFilterReqDTO filter);
        public Task<List<QCRequest>> FindQCRequestFromWFXAsync(QCRequestFilterReqDTO filter);
        public Task<QCRequest> CreateAsync(QCRequestCreateResDTO qc);
        public Task<QCRequest> UpdateAsync(QCRequestUpdateResDTO qc);
        Task<QCRequest> DeleteAsync(Guid id);
    }
}
