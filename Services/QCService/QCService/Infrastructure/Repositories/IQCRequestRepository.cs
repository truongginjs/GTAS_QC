using QCService.DTOs.Requests;
using QCService.Models.D01;
using SINNIKA.EFCore.Initialize;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QCService.Infrastructure.Repositories
{
    public interface IQCRequestRepository : IRepository<QCDetail>
    {
        public Task<List<QCRequest>> FindQCRequestInStorageAsync(QCRequestFilterReqDTO filter);
        //public QCRequest GetOne();
        public Task<QCRequest> CreateAsync(QCRequestCreateResDTO qc);
        public Task<QCRequest> UpdateAsync(Guid id, QCRequestUpdateReqDTO qc);
        Task<QCRequest> DeleteQCRequestAsync(Guid id);
    }
}