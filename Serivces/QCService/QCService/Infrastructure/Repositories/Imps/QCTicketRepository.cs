using Microsoft.EntityFrameworkCore;
using QCService.Models;
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