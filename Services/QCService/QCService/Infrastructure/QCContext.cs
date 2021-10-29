using Microsoft.EntityFrameworkCore;
using QCService.Models.C01;
using QCService.Models.C02;

namespace QCService.Infrastructure
{
    public class QCContext : DbContext
    {
        public virtual DbSet<QCTicket> QCTicket { get; set; }
        public virtual DbSet<QCRequest> QCRequest { get; set; }
        public virtual DbSet<AQLLib> AQLLib { get; set; }
        public virtual DbSet<DefectLib> DefectLib { get; set; }
        public virtual DbSet<QCZoneTypeLib> QCZoneTypeLib { get; set; }
        public QCContext(DbContextOptions<QCContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedFakeData();
        }
    }
}