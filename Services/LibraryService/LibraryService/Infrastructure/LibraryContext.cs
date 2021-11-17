using Microsoft.EntityFrameworkCore;
using LibraryService.Models;
using System.Linq;
using System;
using LibraryService.Models.L01;

namespace LibraryService.Infrastructure
{
    public class LibraryContext : DbContext
    {
        public virtual DbSet<AQLLib> AQLLib { get; set; }
        public virtual DbSet<DefectLib> DefectLib { get; set; }
        public virtual DbSet<QCZoneTypeLib> QCZoneTypeLib { get; set; }
        public virtual DbSet<HandlerDefectLib> HandlerDefectLib { get; set; }
        public virtual DbSet<TimeDefectLib> TimeDefectLib { get; set; }
        public virtual DbSet<SiteLib> SiteLib { get; set; }


        public virtual DbSet<JsonResponse> JsonResponse { get; set; }
        public virtual DbSet<JsonBinaryResponse> JsonBinaryResponse { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JsonResponse>().HasNoKey().ToView(null);
            modelBuilder.Entity<JsonBinaryResponse>().HasNoKey().ToView(null);
            //modelBuilder.SeedFakeData();
        }
    }
}