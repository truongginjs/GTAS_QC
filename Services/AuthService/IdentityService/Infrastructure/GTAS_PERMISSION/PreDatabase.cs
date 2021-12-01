using IdentityService.Infrastructure.GTAS_PERMISSION.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Infrastructure.GTAS_PERMISSION
{
    public static class PreDatabase
    {
        private static readonly DateTime now = DateTime.Now;
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionPermission>().HasData(SeedActionPermission());
            modelBuilder.Entity<Page>().HasData(SeedPage());
            modelBuilder.Entity<GroupPermission>().HasData(SeedGroupPermission());
        }

        private static Page[] SeedPage()
        {
            var data = new Page[] {
new Page{Id= Guid.Parse("a992dbae-fb54-4be8-900f-e97bbe72f8e5"),Code="0001",Name="ListQC",Description="",CreateDate=now,UpdateDate=now},
new Page{Id= Guid.Parse("643f8c10-863f-4ef9-beed-5464454d8149"),Code="0002",Name="QCDetail",Description="",CreateDate=now,UpdateDate=now},
new Page{Id= Guid.Parse("0ff80ad4-0d0e-43b4-a8ae-f6b85098d7cd"),Code="0003",Name="",Description="",CreateDate=now,UpdateDate=now},
new Page{Id= Guid.Parse("aff5eda5-d4e7-4183-88a5-9066842b26ce"),Code="0004",Name="",Description="",CreateDate=now,UpdateDate=now},
new Page{Id= Guid.Parse("a9d337dc-fee6-4d2a-ad5a-8e02fa754221"),Code="0005",Name="",Description="",CreateDate=now,UpdateDate=now},
            };
            return data;
        }

        private static ActionPermission[] SeedActionPermission()
        {
            var data = new ActionPermission[] {
                new ActionPermission { Id=Guid.Parse("d8c51486-4370-4793-a3f8-011eb7265ac8"),Name= "Create", Description="Create", CreateDate=now,UpdateDate=now},
                new ActionPermission { Id=Guid.Parse("24cfad1b-ff7b-4578-a309-17cf2407ce2f"),Name= "Read",   Description="Read",   CreateDate=now,UpdateDate=now},
                new ActionPermission { Id=Guid.Parse("5e195d74-efe6-45e5-9917-c97516fce5ee"),Name= "Update", Description="Update", CreateDate=now,UpdateDate=now},
                new ActionPermission { Id=Guid.Parse("5e3d03fb-c6f6-4580-96a4-9302eb398433"),Name= "Delete", Description="Delete", CreateDate=now,UpdateDate=now},
                new ActionPermission { Id=Guid.Parse("7f64f165-c10e-4244-9309-72ee2eb3c798"),Name= "Approve",Description="Approve",CreateDate=now,UpdateDate=now},
                new ActionPermission { Id=Guid.Parse("64a2dfd3-591f-4cbe-b9bb-a942ebb5884b"),Name= "Lock",   Description="Lock",   CreateDate=now,UpdateDate=now},
                new ActionPermission { Id=Guid.Parse("7dc6991b-29c6-43dd-9f44-f5024cb7517b"),Name= "Unlock", Description="Unlock", CreateDate=now,UpdateDate=now},
                new ActionPermission { Id=Guid.Parse("1d3f685a-495e-4b48-b00e-84dc18e0ec92"),Name= "Import", Description="Import", CreateDate=now,UpdateDate=now},
                new ActionPermission { Id=Guid.Parse("65744dd0-1a9b-4a67-9955-431e4e9bd534"),Name= "Export", Description="Export", CreateDate=now,UpdateDate=now},
                new ActionPermission { Id=Guid.Parse("ea15b1d3-e54b-4989-ad48-87dccf0f9105"),Name= "Admin",  Description="Admin",  CreateDate=now,UpdateDate=now}
            };
            return data;
        }

        private static GroupPermission[] SeedGroupPermission()
        {
            return new GroupPermission[] { new GroupPermission
                {
                    Id = Guid.Parse("9c572ddb-04c5-4e5b-aa96-c42464944313"),
                    CreateDate = now,
                    UpdateDate = now,
                    Name = "USER",
                    Description="user",
                    Functions = new Models.DTOs.FunctionsDTO
                    {
                        Pages = new List<Models.DTOs.PageDTO>
                        {
                            new Models.DTOs.PageDTO{}
                        }
                    }

                },
                new GroupPermission
                {
                    Id = Guid.Parse("9c572ddb-04c5-4e5b-aa96-c42464944313"),
                    CreateDate = now,
                    UpdateDate = now,
                    Name = "MANAGER",
                    Description = "manager (leader)",
                    Functions = new Models.DTOs.FunctionsDTO
                    {
                        Pages = new List<Models.DTOs.PageDTO>
                        {
                            new Models.DTOs.PageDTO{}
                        }
                    }

                },
                new GroupPermission
                {
                    Id = Guid.Parse("9c572ddb-04c5-4e5b-aa96-c42464944313"),
                    CreateDate = now,
                    UpdateDate = now,
                    Name = "ADMIN",
                    Description = "admin (super user)",
                    Functions = new Models.DTOs.FunctionsDTO
                    {
                        Pages = new List<Models.DTOs.PageDTO>
                        {
                            new Models.DTOs.PageDTO{}
                        }
                    }

                }};
        }
    }
}
