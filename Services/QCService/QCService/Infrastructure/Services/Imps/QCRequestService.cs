﻿using QCService.DTOs.Requests;
using QCService.Helpers.Enums;
using QCService.Infrastructure.Repositories;
using QCService.Models.D01;
using QCService.Models.DTOs;
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
            var data = Task.Run(()=> _jsonRepo.ExecuteData<List<QCRequest>>(sp, active, out string message, param));
            return data;
        }

        public Task<List<QCTicketDTO>> FindQCTicketAsync(QCRequestFilterReqDTO filter)
        {
            var sp = StoreProcedureType.sp_QCTicket;
            var active = ActiveType.Find;
            var param = JsonSerializer.Serialize(filter);
            var data = Task.Run(() => _jsonRepo.ExecuteData<List<QCTicketDTO>>(sp, active, out string message, param));
            return data;
        }

        public Task<QCTicketDTO> GetQCTicketAsync(Guid Id)
        {
            var sp = StoreProcedureType.sp_QCTicket;
            var active = ActiveType.Get;
            var param = Id.ToString();
            var data = Task.Run(() => _jsonRepo.ExecuteData<QCTicketDTO>(sp, active, out string message, param));
            return data;
        }

        public Task<QCTicketDTO> DeleteQCTicketAsync(Guid Id)
        {
            var sp = StoreProcedureType.sp_QCTicket;
            var active = ActiveType.Delete;
            var param = Id.ToString();
            var data = Task.Run(() => _jsonRepo.ExecuteData<QCTicketDTO>(sp, active, out string message, param));
            return data;
        }

        public Task<QCTicketDTO> AddOrUpdateQCTicketAsync(QCTicketDTO qCTicket)
        {
            var sp = StoreProcedureType.sp_QCTicket;
            var active = ActiveType.Save;
            var param = JsonSerializer.Serialize(qCTicket); ;
            var data = Task.Run(() => _jsonRepo.ExecuteData<QCTicketDTO>(sp, active, out string message, param));
            return data;
        }

        public Task<List<QCRequest>> FindQCRequestInStorageAsync(QCRequestFilterReqDTO filter) => _qcRepo.FindQCRequestInStorageAsync(filter);
        
        public Task<QCRequest> CreateAsync(QCRequestCreateResDTO qc) => _qcRepo.CreateAsync(qc);

        public Task<QCRequest> UpdateAsync(QCRequestUpdateReqDTO qc) => _qcRepo.UpdateAsync(qc.Id, qc);

        public Task<QCRequest> DeleteAsync(Guid id) => _qcRepo.DeleteQCRequestAsync(id);
    }
}