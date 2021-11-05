using LibraryService.Models.L01;

namespace LibraryService.Infrastructure.Repositories.Imps
{
    public class ZoneTypeRepository : MyGenericRepository<QCZoneTypeLib>, IZoneTypeRepository
    {
        public ZoneTypeRepository(LibraryContext context) : base(context)
        {
        }

        
    }
}