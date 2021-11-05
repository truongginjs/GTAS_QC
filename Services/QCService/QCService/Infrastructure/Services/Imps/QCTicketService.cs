using QCService.DTOs.Requests;
using QCService.Helpers.Enums;
using QCService.Infrastructure.Repositories;
using QCService.Models.D01;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace QCService.Infrastructure.Services.Imps
{
    public class QCTicketService : IQCTicketService
    {
        private readonly IQCTicketRepository _qcRepo;
        private readonly IJsonRepository _jsonRepo;

        public QCTicketService(IQCTicketRepository qcRepo, IJsonRepository jsonRepo)
        {
            _qcRepo = qcRepo;
            _jsonRepo = jsonRepo;
        }

        public Task<QCTicket> GetAsync(Guid id) => _qcRepo.GetAsync(id);


        public Task<List<QCRequest>> FindQCRequestFromWFXAsync(QCRequestFilterReqDTO filter)
        {

            var sp = StoreProcedureType.sp_WFXQCRequest;
            var active = ActiveType.Find;
            var param = JsonSerializer.Serialize(filter);
            var data = Task.Run(()=> _jsonRepo.ExecuteData<List<QCRequest>>(sp, active, out string message, param));
            return data;
        }

        public Task<List<QCRequest>> FindQCRequestInStorageAsync(QCRequestFilterReqDTO filter) => _qcRepo.FindQCRequestInStorageAsync(filter);
        
        public Task<QCRequest> CreateAsync(QCRequestCreateResDTO qc) => _qcRepo.CreateAsync(qc);

        public Task<QCRequest> UpdateAsync(QCRequestUpdateResDTO qc) => _qcRepo.UpdateAsync(qc.Id, qc);

        public Task<QCRequest> DeleteAsync(Guid id) => _qcRepo.DeleteQCRequestAsync(id);
    }
}
