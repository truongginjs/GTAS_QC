using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LibraryService.Models;

namespace LibraryService.Infrantruture
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
            builder.Entity<ZoneType>().HasData(GenFakeData(5));
            return builder;
        }

        public static ZoneType[] GenFakeData(int v=1)
        {
            if(v<1) return null;
            var result = Enumerable.Range(0,v).Select(i=>{
                return new ZoneType{
                    Id = Guid.NewGuid(),
                    Name = $"ZoneType Name {i + 1}",
                    Description=$"ZoneType Description {i + 1}"
                    
                };

            }).ToArray();
            return result;
        }

        public static void SeedFakeData(this LibraryContext context)
        {
            if (!context.ZoneType.Any())
            {
                Console.WriteLine("====> Seeding fake data ...");
                context.AddRange(
                    new ZoneType { Id = Guid.NewGuid(), Name = "QCTicket 1", Description = "Des QCTicket 1" },
                    new ZoneType { Id = Guid.NewGuid(), Name = "QCTicket 2", Description = "Des QCTicket 2" },
                    new ZoneType { Id = Guid.NewGuid(), Name = "QCTicket 3", Description = "Des QCTicket 3" }
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