using System;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QCService.Models.C01;
using QCService.Models.C02;
using QCService.Models.Enums;

namespace QCService.Infrastructure
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












        public static ModelBuilder SeedFakeData(this ModelBuilder builder)
        {
            builder.Entity<QCZoneTypeLib>().HasData(
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group1, Id = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Code = "Fabric Storage Has Roll", Name = "Fabric Storage Has Roll", Description = "kho vải có roll", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group2, Id = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Code = "Fabric Storage Has no Roll", Name = "Fabric Storage Has no Roll", Description = "kho vải không roll", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group2, Id = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Code = "Operation", Name = "Operation", Description = "kho nguyên phụ liệu", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Code = "Cut Operation", Name = "Cut Operation", Description = "công đoạn cắt (CUT)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("93492f52-c22d-4224-8770-fcf410062e6a"), Code = "Print Operation", Name = "Print Operation", Description = "công đoạn in (PRINT)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("de72a6a9-bd09-48e3-b48e-19494d3ddb43"), Code = "Emboidery Operation", Name = "Emboidery Operation", Description = "công đoạn thuê (EMBOIDERY)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Code = "Sew Operation", Name = "Sew Operation", Description = "công đoạn may (SEW)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Code = "Finish Operation", Name = "Finish Operation", Description = "công đoạn wash (SEND TO FINISH)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Code = "Packing Operation", Name = "Packing Operation", Description = "công đoạn hoàn tất (PACKING)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group4, Id = Guid.Parse("c414c4a2-eca1-4cc3-b598-99d7f1c5b1ec"), Code = "Pre-Final", Name = "Pre-Final", Description = "Pre-Final", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group4, Id = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Code = "Final", Name = "Final", Description = "Final", CreateDate = DateTime.Now, UpdateDate = DateTime.Now }
            );

            builder.Entity<AQLLib>().HasData(
                new AQLLib { Id = Guid.Parse("9f6f0a5a-900e-44b0-9fb7-dbe1dd1aed66"), Category = "AQL 2.5", SeqNo = 2, LotSize = "51-90", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new AQLLib { Id = Guid.Parse("ac1c939d-2ef6-42c5-a953-d535af0a0475"), Category = "AQL 2.5", SeqNo = 3, LotSize = "91-150", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new AQLLib { Id = Guid.Parse("3f11283f-d11b-4266-b658-16e82b01d991"), Category = "AQL 2.5", SeqNo = 4, LotSize = "151-280", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new AQLLib { Id = Guid.Parse("02884a90-921e-44fe-a6f3-4d56bc660d98"), Category = "AQL 2.5", SeqNo = 5, LotSize = "281-500", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new AQLLib { Id = Guid.Parse("2bf9a034-9773-4763-b45a-62cb64b4fe60"), Category = "AQL 2.5", SeqNo = 6, LotSize = "501-1.200", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new AQLLib { Id = Guid.Parse("20307cd9-7775-437b-b56f-3decd98ba56e"), Category = "AQL 2.5", SeqNo = 7, LotSize = "1.201-3.200", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new AQLLib { Id = Guid.Parse("c0619a96-4bc9-4036-8699-7f29ba9f035c"), Category = "AQL 2.5", SeqNo = 8, LotSize = "3.201-10.000", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new AQLLib { Id = Guid.Parse("a008c1d5-bea1-4790-aa14-d37e300593f1"), Category = "AQL 2.5", SeqNo = 9, LotSize = "15.001-500.000", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new AQLLib { Id = Guid.Parse("81c393a2-6188-4012-8f42-85fd197f273b"), Category = "AQL 2.5", SeqNo = 10, LotSize = "500.000 over", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new AQLLib { Id = Guid.Parse("7680f05d-5794-454c-85b1-2291e4882828"), Category = "Sizeset-Pilot", SeqNo = 1, LotSize = "10", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new AQLLib { Id = Guid.Parse("4facb93b-a39d-4941-858b-6955b5e90eca"), Category = "Sizeset-Pilot", SeqNo = 2, LotSize = "20", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new AQLLib { Id = Guid.Parse("baf4f214-b6d4-4f59-ba03-c642d3806299"), Category = "Sizeset-Pilot", SeqNo = 3, LotSize = "30", CreateDate = DateTime.Now, UpdateDate = DateTime.Now }
            );

            builder.Entity<DefectLib>().HasData(
                new DefectLib { Id = Guid.Parse("92e46adb-51cb-41d5-9252-f572e309399e"), Code = "S01", Name = "Proplem1", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), HandlersJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} soluiton{i + 1} Handler{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new DefectLib { Id = Guid.Parse("7da1e425-7ebb-40ef-a868-7a3ba7e38214"), Code = "S01", Name = "Proplem2", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem2 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem2 reason{i + 1} solution{i + 1}")), HandlersJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem2 reason{i + 1} soluiton{i + 1} Handler{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new DefectLib { Id = Guid.Parse("0063529e-81d9-4d53-bd4a-1fd21496dc97"), Code = "S01", Name = "Proplem3", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem3 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem3 reason{i + 1} solution{i + 1}")), HandlersJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem3 reason{i + 1} soluiton{i + 1} Handler{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new DefectLib { Id = Guid.Parse("e1bedd68-8c62-4320-bcd3-a2692398e0e8"), Code = "S01", Name = "Proplem4", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem4 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem4 reason{i + 1} solution{i + 1}")), HandlersJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem4 reason{i + 1} soluiton{i + 1} Handler{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new DefectLib { Id = Guid.Parse("b8f567f2-c62b-431e-acc8-79ca56dc9aa8"), Code = "S01", Name = "Proplem5", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem5 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem5 reason{i + 1} solution{i + 1}")), HandlersJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem5 reason{i + 1} soluiton{i + 1} Handler{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new DefectLib { Id = Guid.Parse("9c1d76c0-4e0a-4dae-b2ec-c06a906442b6"), Code = "S01", Name = "Proplem6", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem6 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem6 reason{i + 1} solution{i + 1}")), HandlersJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem6 reason{i + 1} soluiton{i + 1} Handler{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now }
            );


            // builder.Entity<Defect>().HasData(GenFakeQCTicket(5));
            return builder;
        }



        // private static QCTicket[] GenFakeQCTicket(int v = 1)
        // {
        //     if (v < 1) return null;
        //     var result = Enumerable.Range(0, v).Select(i =>
        //     {
        //         return new QCTicket
        //         {
        //             Id = Guid.NewGuid(),
        //             Name = $"QCTicket Name {i + 1}",
        //             Buyer = new Buyer
        //             {
        //                 Id = Guid.NewGuid(),
        //                 Description = $"QCTicket Buyer Description {i + 1}"
        //             }

        //         };

        //     }).ToArray();
        //     return result;
        // }

        public static void SeedFakeData(this QCContext context)
        {
            if (!context.QCTicket.Any())
            {
                Console.WriteLine("====> Seeding fake data ...");
                context.AddRange(
                    new QCTicket { Id = Guid.NewGuid(), Code = "Code_1", Name = "QCTicket Name 1" },
                    new QCTicket { Id = Guid.NewGuid(), Code = "Code_2", Name = "QCTicket Name 2" },
                    new QCTicket { Id = Guid.NewGuid(), Code = "Code_3", Name = "QCTicket Name 3" }
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