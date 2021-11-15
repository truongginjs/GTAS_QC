using LibraryService.Models.L01;

namespace LibraryService.Infrastructure.Repositories.Imps
{
    public class HandlerDefectRepository : MyGenericRepository<HandlerDefectLib>, IHandlerDefectRepository
    {
        public HandlerDefectRepository(LibraryContext context) : base(context)
        {
        }
    }
}
