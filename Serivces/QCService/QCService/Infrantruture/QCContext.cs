using Microsoft.EntityFrameworkCore;
using QCService.Models;

namespace QCService.Infrantruture
{
    public class QCContext:DbContext
    {
        public virtual DbSet<QCTicket> QCTicket { get; set; }
        public virtual DbSet<AQLLibrary> AQLLibrary { get; set; }
        public virtual DbSet<Defect> Defect { get; set; }
        public virtual DbSet<QCZoneType> ZoneType { get; set; }
        public QCContext(DbContextOptions<QCContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedFakeData();
        }
    }
}