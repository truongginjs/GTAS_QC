using Microsoft.EntityFrameworkCore;
using LibraryService.Models;
using SINNIKA.EFCore.Initialize;

namespace LibraryService.Infrastructure.Repositories.Imps
{
    public class ZoneTypeRepository : GenericRepository<ZoneType>, IZoneTypeRepository
    {
        public ZoneTypeRepository(LibraryContext context) : base(context)
        {
        }
    }
}