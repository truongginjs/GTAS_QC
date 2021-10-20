using Microsoft.EntityFrameworkCore;
using QCService.Models;

namespace QCService.Infrantruture
{
    public class QCContext:DbContext
    {
        public DbSet<QCTicket> QCTicket { get; set; }
        public QCContext(DbContextOptions<QCContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedFakeData();
        }
    }
}