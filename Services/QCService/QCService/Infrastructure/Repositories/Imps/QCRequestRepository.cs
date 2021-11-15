using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QCService.DTOs.Requests;
using QCService.Models.D01;
using SINNIKA.EFCore.Initialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QCService.Infrastructure.Repositories.Imps
{
    public class QCRequestRepository : GenericRepository<QCDetail>, IQCRequestRepository
    {
        private readonly DbSet<QCRequest> _QCRequest;
        private readonly DbSet<QCDetail> _QCTicket;
        private readonly QCContext _context;
        private readonly IMapper _mapper;

        public QCRequestRepository(QCContext context, IMapper mapper) : base(context)
        {
            _QCRequest = context.QCRequest;
            _QCTicket = context.QCDetail;
            _context = context;
            _mapper = mapper;
        }

   
        public async Task<List<QCRequest>> FindQCRequestInStorageAsync(QCRequestFilterReqDTO filter)
        {
            var result = await _QCRequest.Where(x => x.QCRequestDate <= filter.ToDate && x.QCRequestDate >= filter.FromDate && x.OCNumber.Contains(filter.OCNumber) && x.QCNumber.Contains(filter.QCNumber)).ToListAsync();
            return result;
        }

        public override Task<QCDetail> GetAsync(object Id)
        {
            return _QCTicket.Where(x => Id.Equals(x.Id)).Include(x => x.QCRequest).FirstOrDefaultAsync();
        }

        public async Task<QCRequest> CreateAsync(QCRequestCreateResDTO qc)
        {
            var id = Guid.NewGuid();
            var qcRequest = _mapper.Map<QCRequest>(qc);
            qcRequest.Id = id;
            var qcTicket = new QCDetail { Id = id };

            _QCRequest.Add(qcRequest);
            _QCTicket.Add(qcTicket);

            await _context.SaveChangesAsync();
            return qcRequest;
        }


        public async Task<QCRequest> UpdateAsync(Guid id, QCRequestUpdateReqDTO qc)
        {
            var qcRequest = _mapper.Map<QCRequest>(qc);
            _QCRequest.Update(qcRequest);

            await _context.SaveChangesAsync();

            return qcRequest;
        }

        public async Task<QCRequest> DeleteQCRequestAsync(Guid id)
        {
            var data = await _QCRequest.Include(x=>x.QCDetail).Where(x=>x.Id==id).FirstOrDefaultAsync();
            data.IsDeleted = true;
            if(data.QCDetail != null)
                data.QCDetail.IsDeleted = true;
            
            await _context.SaveChangesAsync();

            return data;
        }
    }
}