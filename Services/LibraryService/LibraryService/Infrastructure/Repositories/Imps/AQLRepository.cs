using LibraryService.Models.L01;

namespace LibraryService.Infrastructure.Repositories.Imps
{
    public class AQLRepository : MyGenericRepository<AQLLib>, IAQLRepository
    {

        public AQLRepository(LibraryContext context) : base(context)
        {
        }
    }
}
