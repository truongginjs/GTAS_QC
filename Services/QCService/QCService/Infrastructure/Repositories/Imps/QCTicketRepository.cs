using QCService.Models.C02;
using SINNIKA.EFCore.Initialize;

namespace QCService.Infrastructure.Repositories.Imps
{
    public class QCTicketRepository : GenericRepository<QCTicket>, IQCTicketRepository
    {
        public QCTicketRepository(QCContext context) : base(context)
        {
            
        }
    }
}