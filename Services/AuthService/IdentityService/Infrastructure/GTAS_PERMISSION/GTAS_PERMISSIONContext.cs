using IdentityService.Infrastructure.GTAS_PERMISSION.Models;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IdentityService.Infrastructure.GTAS_PERMISSION
{
    public partial class GTAS_PERMISSIONContext : DbContext
    {
        public GTAS_PERMISSIONContext()
        {
        }

        public GTAS_PERMISSIONContext(DbContextOptions<GTAS_PERMISSIONContext> options)
            : base(options)
        {
        }
        public virtual DbSet<TblRefreshToken> RefreshToken { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<GroupPermission> GroupPermission { get; set; }
        public virtual DbSet<ActionPermission> ActionPermission { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.SeedData();
        }

    }
}
