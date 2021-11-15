using LibraryService.Models.L01;

namespace LibraryService.Infrastructure.Repositories.Imps
{
    public class TimeDefectRepository : MyGenericRepository<TimeDefectLib>, ITimeDefectRepository
    {
        public TimeDefectRepository(LibraryContext context) : base(context)
        {
        }
    }
}
