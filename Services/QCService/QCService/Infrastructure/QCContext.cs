using Microsoft.EntityFrameworkCore;
using QCService.Models.L01;
using QCService.Models.D01;
using QCService.Models;

namespace QCService.Infrastructure
{
    public class QCContext : DbContext
    {
        public virtual DbSet<QCDetail> QCTicket { get; set; }
        public virtual DbSet<QCRequest> QCRequest { get; set; }
        public virtual DbSet<AQLLib> AQLLib { get; set; }
        public virtual DbSet<DefectLib> DefectLib { get; set; }
        public virtual DbSet<QCZoneTypeLib> QCZoneTypeLib { get; set; }
        public virtual DbSet<JsonResponse> JsonResponse { get; set; }
        public virtual DbSet<JsonBinaryResponse> JsonBinaryData { get; set; }

        public QCContext(DbContextOptions<QCContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JsonResponse>().HasNoKey();
            modelBuilder.Entity<JsonBinaryResponse>().HasNoKey();
            modelBuilder.SeedFakeData();
        }
    }
}