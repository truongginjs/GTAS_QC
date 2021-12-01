using QCService.DTOs.Requests;
using QCService.DTOs.Responses;
using QCService.Helpers.Enums;
using QCService.Infrastructure.Repositories;
using QCService.Models.D01;
using QCService.Models.DTOs;
using QCService.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace QCService.Infrastructure.Services.Imps
{
    public class QCRequestService : IQCRequestService
    {
        private readonly Repositories.IQCRequestRepository _qcRepo;
        private readonly IJsonRepository _jsonRepo;

        public QCRequestService(Repositories.IQCRequestRepository qcRepo, IJsonRepository jsonRepo)
        {
            _qcRepo = qcRepo;
            _jsonRepo = jsonRepo;
        }

        public Task<QCDetail> GetAsync(Guid id) => _qcRepo.GetAsync(id);


        public Task<List<QCRequest>> FindQCRequestFromWFXAsync(QCRequestFilterReqDTO filter)
        {

            var sp = StoreProcedureType.sp_WFXQCRequest;
            var active = ActiveType.Find;
            var param = JsonSerializer.Serialize(filter);
            var data = Task.Run(() => _jsonRepo.ExecuteData<List<QCRequest>>(sp, active, out string message, param));
            return data;
        }

        public Task<List<QCRequestResDBDTO>> FindQCRequestAsync(QCRequestListReqDTO filter)
        {
            var sp = StoreProcedureType.sp_QCDetail;
            var active = ActiveType.Find;
            var param = JsonSerializer.Serialize(filter);
            var data = Task.Run(() => _jsonRepo.ExecuteData<List<QCRequestResDBDTO>>(sp, active, out string message, param));
            return data;
        }

        public Task<QCRequestDetailResDBDTO> GetQCRequestAsync(Guid Id)
        {
            var sp = StoreProcedureType.sp_QCDetail;
            var active = ActiveType.Get;
            var param = JsonSerializer.Serialize(new { id = Id });
            var data = Task.Run(() => _jsonRepo.ExecuteData<QCRequestDetailResDBDTO>(sp, active, out string message, param));
            return data;
        }

        public Task<QCRequestDetailResDBDTO> DeleteQCRequestAsync(Guid Id)
        {
            var sp = StoreProcedureType.sp_QCDetail;
            var active = ActiveType.Delete;
            var param = JsonSerializer.Serialize(new { id = Id });
            var data = Task.Run(() => _jsonRepo.ExecuteData<QCRequestDetailResDBDTO>(sp, active, out string message, param));
            return data;
        }

        public Task<QCRequestDetailResDBDTO> AddOrUpdateQCRequestAsync(QCRequestDetailReqDBDTO qCRequestDetail)
        {
            if (qCRequestDetail.Id == Guid.Empty)
            {
                qCRequestDetail.Id = Guid.NewGuid();
            }
            var sp = StoreProcedureType.sp_QCDetail;
            var active = ActiveType.Save;
            var param = JsonSerializer.Serialize(qCRequestDetail); ;
            var data = Task.Run(() => _jsonRepo.ExecuteData<QCRequestDetailResDBDTO>(sp, active, out string message, param));
            return data;
        }

        public Task<bool> ApproveQCRequestAsync(Guid Id, DocStatusEnum docStatusEnum)
        {
            var sp = StoreProcedureType.sp_QCDetail;
            var active = ActiveType.Approve;
            var param = JsonSerializer.Serialize(new { id = Id, docStatus = docStatusEnum });
            var data = Task.Run(() => _jsonRepo.ExecuteData<ResultDB>(sp, active, out string message, param));

            Task<bool> result = data.ContinueWith(t => bool.Parse(t.Result.Result));
            return result;
        }

        public Task<bool> TransferQCRequestAsync(Guid Id, TransferStatusEnum transferStatusEnum)
        {
            var sp = StoreProcedureType.sp_QCDetail;
            var active = ActiveType.Transfer;
            var param = JsonSerializer.Serialize(new { id = Id, transferStatus = transferStatusEnum });
            var data = Task.Run(() => _jsonRepo.ExecuteData<ResultDB>(sp, active, out string message, param));

            Task<bool> result = data.ContinueWith(t => bool.Parse(t.Result.Result));
            return result;
        }

        public Task<List<QCRequestResDBDTO>> SearchQCRequestAsync(FindQCRequestReqDTO filter)
        {
            var sp = StoreProcedureType.sp_WFXQCRequest;
            var active = ActiveType.Find;
            var param = JsonSerializer.Serialize(filter);
            var data = Task.Run(() => _jsonRepo.ExecuteData<List<QCRequestResDBDTO>>(sp, active, out string message, param));
            return data;
        }

        public Task<List<QCRequest>> FindQCRequestInStorageAsync(QCRequestFilterReqDTO filter) => _qcRepo.FindQCRequestInStorageAsync(filter);

        public Task<QCRequest> CreateAsync(QCRequestCreateResDTO qc) => _qcRepo.CreateAsync(qc);

        public Task<QCRequest> UpdateAsync(QCRequestUpdateReqDTO qc) => _qcRepo.UpdateAsync(qc.Id, qc);

        public Task<QCRequest> DeleteAsync(Guid id) => _qcRepo.DeleteQCRequestAsync(id);

        public class ResultDB
        {
            public string Result { get; set; }
        }
    }
}
