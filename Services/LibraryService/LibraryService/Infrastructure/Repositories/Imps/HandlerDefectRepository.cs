using LibraryService.DTOs.Responses;
using LibraryService.Models.L01;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryService.Infrastructure.Repositories.Imps
{
    public class HandlerDefectRepository : MyGenericRepository<HandlerDefectLib>, IHandlerDefectRepository
    {
        private readonly DbSet<HandlerDefectLib> _table;

       
        public HandlerDefectRepository(LibraryContext context) : base(context)
        {
            _table = context.HandlerDefectLib;

        }

        public async Task<IEnumerable<HandlerDefectLib>> GetsInfoAsync()
        {
            var data = await _table.ToListAsync();
            return data;
        }
    }
}
