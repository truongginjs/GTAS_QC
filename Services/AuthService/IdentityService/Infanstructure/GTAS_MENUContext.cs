using IdentityService.Models;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IdentityService.Infanstructure
{
    public partial class GTAS_MENUContext : DbContext
    {
        public GTAS_MENUContext()
        {
        }

        public GTAS_MENUContext(DbContextOptions<GTAS_MENUContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblApplication> TblApplications { get; set; }
        public virtual DbSet<TblClass> TblClasses { get; set; }
        public virtual DbSet<TblClassDetail> TblClassDetails { get; set; }
        public virtual DbSet<TblPermission> TblPermissions { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblRolePermission> TblRolePermissions { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUserApplication> TblUserApplications { get; set; }
        public virtual DbSet<TblUserPermission> TblUserPermissions { get; set; }
        public virtual DbSet<TblUserRole> TblUserRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblApplication>(entity =>
            {
                entity.HasKey(e => e.AppId);

                entity.ToTable("tblApplications");

                entity.Property(e => e.AppId).HasColumnName("AppID");

                entity.Property(e => e.AppGroup).HasMaxLength(100);

                entity.Property(e => e.AppImage).HasColumnType("image");

                entity.Property(e => e.AppName).IsRequired();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.ErrorUrl)
                    .HasMaxLength(300)
                    .HasColumnName("ErrorURL");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.PublisherName).HasMaxLength(100);

                entity.Property(e => e.SuiteName).HasMaxLength(100);

                entity.Property(e => e.SupportUrl)
                    .HasMaxLength(300)
                    .HasColumnName("SupportURL");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<TblClass>(entity =>
            {
                entity.HasKey(e => e.ClassCode);

                entity.ToTable("tblClass");

                entity.Property(e => e.ClassCode).ValueGeneratedNever();

                entity.Property(e => e.ClassDescription).IsRequired();

                entity.Property(e => e.ClassFieldName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClassImg).HasColumnType("image");

                entity.Property(e => e.ClassName).HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<TblClassDetail>(entity =>
            {
                entity.HasKey(e => new { e.ClassCode, e.ClassDetailCode });

                entity.ToTable("tblClassDetail");

                entity.Property(e => e.ClassDetailValue).IsRequired();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<TblPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId)
                    .HasName("PK_Permission");

                entity.ToTable("tblPermission");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.PermissionCode).HasMaxLength(50);

                entity.Property(e => e.PermissionName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_Role");

                entity.ToTable("tblRole");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<TblRolePermission>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.PermissionId })
                    .HasName("PK_RolePermission");

                entity.ToTable("tblRole_Permission");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_USERS");

                entity.ToTable("tblUsers");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.EmailAddress1).HasMaxLength(100);

                entity.Property(e => e.EmailAddress2).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.PhoneNo1).HasMaxLength(100);

                entity.Property(e => e.PhoneNo2).HasMaxLength(100);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(10)
                    .HasColumnName("PINCode");

                entity.Property(e => e.SocialNetworkAccount).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserMenuTypeId).HasColumnName("UserMenuTypeID");
            });

            modelBuilder.Entity<TblUserApplication>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.AppId });

                entity.ToTable("tblUser_Application");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AppId).HasColumnName("AppID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<TblUserPermission>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.PermissionId });

                entity.ToTable("tblUser_Permission");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<TblUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("tblUser_Role");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
