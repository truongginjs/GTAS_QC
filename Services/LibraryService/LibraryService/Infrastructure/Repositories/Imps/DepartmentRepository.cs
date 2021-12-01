using LibraryService.Models.L01;

namespace LibraryService.Infrastructure.Repositories.Imps
{
    public class DepartmentRepository : MyGenericRepository<DepartmentLib>, IDepartmentRepository
    {
        public DepartmentRepository(LibraryContext context) : base(context)
        {
        }

        
    }
}