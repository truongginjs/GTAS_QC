using LibraryService.Models.L01;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryService.Infrastructure.Repositories.Imps
{
    public class TimeDefectRepository : MyGenericRepository<TimelineDefectLib>, ITimeDefectRepository
    {
        private readonly DbSet<TimelineDefectLib> _table;

        public TimeDefectRepository(LibraryContext context) : base(context)
        {
            _table = context.TimelineDefectLib;
        }

        public async Task<IEnumerable< TimelineDefectLib>> GetsInfoAsync()
        {
            var data = await _table.ToListAsync();
            return data;
        }
    }
}
