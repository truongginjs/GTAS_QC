using LibraryService.Models.L01;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryService.Infrastructure.Repositories.Imps
{
    public class DefectRepository : MyGenericRepository<DefectLib>, IDefectRepository
    {
        private readonly DbSet<DefectLib> _table;

        public DefectRepository(LibraryContext context) : base(context)
        {
            _table = context.DefectLib;
        }

        public async Task<IEnumerable<DefectLib>> GetsInfoAsync()
        {
             var data = await _table.ToListAsync();
            return data;
        }
    }
}
