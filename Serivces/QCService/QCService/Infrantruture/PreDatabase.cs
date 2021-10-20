using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QCService.Models;

namespace QCService.Infrantruture
{
    public static class PreDatabase
    {
        public static IApplicationBuilder SeedFakeDatabase(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<QCContext>();
                context.SeedFakeData();
            }
            return app;
        }

        public static ModelBuilder SeedFakeData(this ModelBuilder builder){
            builder.Entity<QCTicket>().HasData(GenFakeData(5));
            return builder;
        }

        private static QCTicket[] GenFakeData(int v=1)
        {
            if(v<1) return null;
            var result = Enumerable.Range(0,v).Select(i=>{
                return new QCTicket{
                    Id = Guid.NewGuid(),
                    Name = $"QCTicket Name {i + 1}",
                    Buyer = new Buyer{
                        Id= Guid.NewGuid(),
                        Description= $"QCTicket Buyer Description {i+1}"
                    }
                    
                };

            }).ToArray();
            return result;
        }

        public static void SeedFakeData(this QCContext context)
        {
            if (!context.QCTicket.Any())
            {
                Console.WriteLine("====> Seeding fake data ...");
                context.AddRange(
                    new QCTicket { Id = Guid.NewGuid(), Name = "QCTicket 1", Description = "Des QCTicket 1" },
                    new QCTicket { Id = Guid.NewGuid(), Name = "QCTicket 2", Description = "Des QCTicket 2" },
                    new QCTicket { Id = Guid.NewGuid(), Name = "QCTicket 3", Description = "Des QCTicket 3" }
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