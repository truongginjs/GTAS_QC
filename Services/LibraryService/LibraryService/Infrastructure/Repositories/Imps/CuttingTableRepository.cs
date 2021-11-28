using LibraryService.Models.L01;

namespace LibraryService.Infrastructure.Repositories.Imps
{
    public class CuttingTableRepository : MyGenericRepository<CuttingTableLib>, ICuttingTableRepository
    {
        public CuttingTableRepository(LibraryContext context) : base(context)
        {
        }

        
    }
}