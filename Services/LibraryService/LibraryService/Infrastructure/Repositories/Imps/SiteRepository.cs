using LibraryService.Models.L01;

namespace LibraryService.Infrastructure.Repositories.Imps
{
    public class SiteRepository : MyGenericRepository<SiteLib>, ISiteRepository
    {
        public SiteRepository(LibraryContext context) : base(context)
        {
        }

        
    }
}