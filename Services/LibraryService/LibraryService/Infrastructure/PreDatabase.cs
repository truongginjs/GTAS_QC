using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LibraryService.Models;
using LibraryService.Models.L01;

namespace LibraryService.Infrastructure
{
    public static class PreDatabase
    {
        public static IApplicationBuilder SeedFakeDatabase(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<LibraryContext>();
                context.SeedFakeData();
            }
            return app;
        }

        public static ModelBuilder SeedFakeData(this ModelBuilder builder){
            builder.Entity<QCZoneTypeLib>().HasData(GenFakeData(5));
            return builder;
        }

        public static QCZoneTypeLib[] GenFakeData(int v=1)
        {
            if(v<1) return null;
            var result = Enumerable.Range(0,v).Select(i=>{
                return new QCZoneTypeLib
                {
                    Id = Guid.NewGuid(),
                    Name = $"ZoneType Name {i + 1}",
                    Description=$"ZoneType Description {i + 1}"
                    
                };

            }).ToArray();
            return result;
        }

        public static void SeedFakeData(this LibraryContext context)
        {
            if (!context.QCZoneTypeLib.Any())
            {
                Console.WriteLine("====> Seeding fake data ...");
                context.AddRange(
                    new QCZoneTypeLib { Id = Guid.NewGuid(), Name = "ZoneType 1", Description = "Des ZoneType 1" },
                    new QCZoneTypeLib { Id = Guid.NewGuid(), Name = "ZoneType 2", Description = "Des ZoneType 2" },
                    new QCZoneTypeLib { Id = Guid.NewGuid(), Name = "ZoneType 3", Description = "Des ZoneType 3" }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("====> We already has data.");

            }
        }
    }
}