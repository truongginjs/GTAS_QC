using Microsoft.EntityFrameworkCore;
using LibraryService.Models;
using System.Linq;
using System;

namespace LibraryService.Infrantruture
{
    public class LibraryContext : DbContext
    {

        public DbSet<ZoneType> ZoneType { get; set; }
        public DbSet<AQLLibrary> AQLLibrary { get; set; }
        public DbSet<Defective> Defective { get; set; }
        public DbSet<SolutionDefective> SolutionDefective { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.SeedFakeData();
        }
    }
}