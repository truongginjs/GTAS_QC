using LibraryService.Models.L01;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LibraryService.Infrastructure.Repositories.Imps
{
    public class ZoneTypeRepository : MyGenericRepository<QCZoneTypeLib>, IZoneTypeRepository
    {
        private readonly LibraryContext _context;
        private readonly DbSet<QCZoneTypeLib> _table;

        public ZoneTypeRepository(LibraryContext context) : base(context)
        {
            _context = context;
            _table = context.QCZoneTypeLib;
            
        }

        public override async Task<QCZoneTypeLib> UpdateAsync(object Id, QCZoneTypeLib data)
        {
            var entity = _table.Find(Id);
            if (entity == null) return null;
            data.No = entity.No;
            _context.Entry(entity).CurrentValues.SetValues(data);
            await SaveAsync();
            return data;
            
        }

        public override QCZoneTypeLib Update(object Id, QCZoneTypeLib data)
        {
            var entity = _table.Find(Id);
            if (entity == null) return null;
            data.No = entity.No;
            _context.Entry(entity).CurrentValues.SetValues(data);
            Save();
            return data;
        }
    }
}