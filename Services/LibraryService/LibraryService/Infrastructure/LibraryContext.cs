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
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.SeedFakeData();
        }
    }
}