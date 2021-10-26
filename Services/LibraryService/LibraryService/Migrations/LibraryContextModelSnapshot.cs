﻿// <auto-generated />
using System;
using LibraryService.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryService.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryService.Models.AQLLibrary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("ZoneTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ZoneTypeId");

                    b.ToTable("AQLLibrary");
                });

            modelBuilder.Entity("LibraryService.Models.Defective", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("ZoneTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ZoneTypeId");

                    b.ToTable("Defective");
                });

            modelBuilder.Entity("LibraryService.Models.SolutionDefective", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("ZoneTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ZoneTypeId");

                    b.ToTable("SolutionDefective");
                });

            modelBuilder.Entity("LibraryService.Models.ZoneType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("ZoneType");

                    b.HasData(
                        new
                        {
                            Id = new Guid("329c4ebe-dc09-4fbe-92d4-4770550903e3"),
                            Description = "ZoneType Description 1",
                            Name = "ZoneType Name 1"
                        },
                        new
                        {
                            Id = new Guid("d2bcd226-430d-42e2-b167-24b42acef75d"),
                            Description = "ZoneType Description 2",
                            Name = "ZoneType Name 2"
                        },
                        new
                        {
                            Id = new Guid("27410b30-d180-4085-9ae2-c327f56e8fc1"),
                            Description = "ZoneType Description 3",
                            Name = "ZoneType Name 3"
                        },
                        new
                        {
                            Id = new Guid("21859bd9-27d0-4321-bcf2-7ac5cb36be07"),
                            Description = "ZoneType Description 4",
                            Name = "ZoneType Name 4"
                        },
                        new
                        {
                            Id = new Guid("fbd628eb-6711-4f01-959b-a581473a2523"),
                            Description = "ZoneType Description 5",
                            Name = "ZoneType Name 5"
                        });
                });

            modelBuilder.Entity("LibraryService.Models.AQLLibrary", b =>
                {
                    b.HasOne("LibraryService.Models.ZoneType", "ZoneType")
                        .WithMany()
                        .HasForeignKey("ZoneTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ZoneType");
                });

            modelBuilder.Entity("LibraryService.Models.Defective", b =>
                {
                    b.HasOne("LibraryService.Models.ZoneType", "ZoneType")
                        .WithMany()
                        .HasForeignKey("ZoneTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ZoneType");
                });

            modelBuilder.Entity("LibraryService.Models.SolutionDefective", b =>
                {
                    b.HasOne("LibraryService.Models.ZoneType", "ZoneType")
                        .WithMany()
                        .HasForeignKey("ZoneTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ZoneType");
                });
#pragma warning restore 612, 618
        }
    }
}