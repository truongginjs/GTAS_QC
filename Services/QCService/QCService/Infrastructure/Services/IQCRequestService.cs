using QCService.DTOs.Requests;
using QCService.DTOs.Responses;
using QCService.Models.D01;
using QCService.Models.DTOs;
using QCService.Models.Enums;
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
        public Task<List<QCRequestResDBDTO>> FindQCRequestAsync(QCRequestListReqDTO filter);
        public Task<QCRequestDetailResDBDTO> GetQCRequestAsync(Guid Id);
        public Task<QCRequestDetailResDBDTO> DeleteQCRequestAsync(Guid Id);
        public Task<QCRequestDetailResDBDTO> AddOrUpdateQCRequestAsync(QCRequestDetailReqDBDTO qCTicket);
        public Task<bool> ApproveQCRequestAsync(Guid Id, DocStatusEnum DocStatus);
        public Task<bool> TransferQCRequestAsync(Guid Id, TransferStatusEnum TransferStatus);
        public Task<List<QCRequestResDBDTO>> SearchQCRequestAsync(FindQCRequestReqDTO filter);
        public Task<QCRequest> CreateAsync(QCRequestCreateResDTO qc);
        public Task<QCRequest> UpdateAsync(QCRequestUpdateReqDTO qc);
        Task<QCRequest> DeleteAsync(Guid id);
    }
}
