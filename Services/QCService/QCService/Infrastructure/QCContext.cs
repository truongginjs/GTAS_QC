using Microsoft.EntityFrameworkCore;
using QCService.Models.L01;
using QCService.Models.D01;
using QCService.Models;
using QCService.Helpers.Extensions;
using QCService.Models.Enums;

namespace QCService.Infrastructure
{
    public class QCContext : DbContext
    {
        public virtual DbSet<QCDetail> QCDetail { get; set; }
        public virtual DbSet<QCRequest> QCRequest { get; set; }
        public virtual DbSet<AQLLib> AQLLib { get; set; }
        public virtual DbSet<DefectLib> DefectLib { get; set; }
        public virtual DbSet<QCZoneTypeLib> QCZoneTypeLib { get; set; }
        public virtual DbSet<HandlerDefectLib> HandlerDefectLib { get; set; }
        public virtual DbSet<TimeDefectLib> TimeDefectLib { get; set; }


        public virtual DbSet<JsonResponse> JsonResponse { get; set; }
        public virtual DbSet<JsonBinaryResponse> JsonBinaryResponse { get; set; }

        public QCContext(DbContextOptions<QCContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JsonResponse>().HasNoKey().ToView(null);
            modelBuilder.Entity<JsonBinaryResponse>().HasNoKey().ToView(null);

            //     modelBuilder
            //        .Entity<QCRequest>()
            //        .Property(e => e.DocStatus)
            //        .HasConversion(
            //            v => v.ToString(),
            //            v => v.ToEnum(DocStatusEnum.Inprogress))
            //;
            modelBuilder.SeedFakeData();
        }
    }
}