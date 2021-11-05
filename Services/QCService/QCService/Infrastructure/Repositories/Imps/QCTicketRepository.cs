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
    public class QCTicketRepository : GenericRepository<QCTicket>, IQCTicketRepository
    {
        private readonly DbSet<QCRequest> _QCRequest;
        private readonly DbSet<QCTicket> _QCTicket;
        private readonly QCContext _context;
        private readonly IMapper _mapper;

        public QCTicketRepository(QCContext context, IMapper mapper) : base(context)
        {
            _QCRequest = context.QCRequest;
            _QCTicket = context.QCTicket;
            _context = context;
            _mapper = mapper;
        }

   
        public async Task<List<QCRequest>> FindQCRequestInStorageAsync(QCRequestFilterReqDTO filter)
        {
            var result = await _QCRequest.Where(x => x.QCRequestDate <= filter.ToDate && x.QCRequestDate >= filter.FromDate && x.OCNumber.Contains(filter.OCNumber) && x.QCNumber.Contains(filter.QCNumber)).ToListAsync();
            return result;
        }

        public override Task<QCTicket> GetAsync(object Id)
        {
            return _QCTicket.Where(x => Id.Equals(x.Id)).Include(x => x.QCRequest).FirstOrDefaultAsync();
        }

        public async Task<QCRequest> CreateAsync(QCRequestCreateResDTO qc)
        {
            var id = Guid.NewGuid();
            var qcRequest = _mapper.Map<QCRequest>(qc);
            qcRequest.Id = id;
            var qcTicket = new QCTicket { Id = id };

            _QCRequest.Add(qcRequest);
            _QCTicket.Add(qcTicket);

            await _context.SaveChangesAsync();
            return qcRequest;
        }


        public async Task<QCRequest> UpdateAsync(Guid id, QCRequestUpdateResDTO qc)
        {
            var qcRequest = _mapper.Map<QCRequest>(qc);
            _QCRequest.Update(qcRequest);

            await _context.SaveChangesAsync();

            return qcRequest;
        }

        public async Task<QCRequest> DeleteQCRequestAsync(Guid id)
        {
            var data = await _QCRequest.Include(x=>x.QCTicket).Where(x=>x.Id==id).FirstOrDefaultAsync();
            data.IsDeleted = true;
            if(data.QCTicket!=null)
                data.QCTicket.IsDeleted = true;
            
            await _context.SaveChangesAsync();

            return data;
        }
    }
}