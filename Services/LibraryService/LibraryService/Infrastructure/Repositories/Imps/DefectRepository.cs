using LibraryService.Models.L01;

namespace LibraryService.Infrastructure.Repositories.Imps
{
    public class DefectRepository : MyGenericRepository<DefectLib>, IDefectRepository
    {
        public DefectRepository(LibraryContext context) : base(context)
        {
        }
    }
}
