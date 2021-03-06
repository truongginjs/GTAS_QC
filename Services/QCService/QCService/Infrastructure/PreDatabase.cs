using System;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QCService.Models.L01;
using QCService.Models.D01;
using QCService.Models.Enums;
using QCService.Models.DTOs;
using System.Collections.Generic;

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
        private static Guid[] Ids;

        public static ModelBuilder SeedFakeData(this ModelBuilder builder)
        {
            var n = 200;
            Ids = Enumerable.Range(0, n).Select(x => Guid.NewGuid()).ToArray();
            var temp = SeedDefect.SeedFullLib();
            var defectLibs = temp.Item1;
            var handlerLibs = temp.Item2;
            var timelineLibs = temp.Item3;
            //var defectLibs = SeedDefectLib();
            var zoneType = SeedZoneTypeLib();
            var qcrequests = SeedQCRequest(zoneType, n);
            var qcdetails = SeedQCDetail(qcrequests, defectLibs);
            



            builder.Entity<QCZoneTypeLib>().HasData(
                zoneType
            );

            builder.Entity<SiteLib>().HasData(
             SeedSiteLib()
         );

            builder.Entity<HandlerDefectLib>().HasData(handlerLibs);

            builder.Entity<DepartmentLib>().HasData(SeedDepartment());
            builder.Entity<CuttingTableLib>().HasData(SeedCuttingTable());

            builder.Entity<TimelineDefectLib>().HasData(timelineLibs);

            builder.Entity<AQLLib>().HasData(
                new AQLLib
                {
                    Id = Guid.Parse("94d900ec-0757-4a06-815d-096bc27b7fb7"),
                    Description = "AQL 100%",
                    RatingMajor = 1,
                    RatingMinor = 2,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new AQLLib { Id = Guid.Parse("9f6f0a5a-900e-44b0-9fb7-dbe1dd1aed66"), Description = "AQL 1.5 level II", RatingMajor = 1, RatingMinor = 2, CreateDate = DateTime.Now, UpdateDate = DateTime.Now , QCRagesJson = JsonSerializer.Serialize(new List<QCRageDTO> {
                    new QCRageDTO{ AllowMajorDefect=0,OfferedQtyFrom = 2, OfferedQtyTo = 8, SampleSize=2},
                    new QCRageDTO{ AllowMajorDefect=0,OfferedQtyFrom = 9, OfferedQtyTo = 15, SampleSize=3},
                    new QCRageDTO{ AllowMajorDefect=0,OfferedQtyFrom = 16, OfferedQtyTo = 25, SampleSize=5},
                    new QCRageDTO{ AllowMajorDefect=1,OfferedQtyFrom = 26, OfferedQtyTo = 50, SampleSize=8},
                    new QCRageDTO{ AllowMajorDefect=1,OfferedQtyFrom = 51, OfferedQtyTo = 90, SampleSize=13},
                    new QCRageDTO{ AllowMajorDefect=1,OfferedQtyFrom = 91, OfferedQtyTo = 150, SampleSize=20},
                    new QCRageDTO{ AllowMajorDefect=2,OfferedQtyFrom = 151, OfferedQtyTo = 280, SampleSize=32},
                    new QCRageDTO{ AllowMajorDefect=3,OfferedQtyFrom = 281, OfferedQtyTo = 500, SampleSize=50},
                    new QCRageDTO{ AllowMajorDefect=5,OfferedQtyFrom = 501, OfferedQtyTo = 1200, SampleSize=80},
                    new QCRageDTO{ AllowMajorDefect=7,OfferedQtyFrom = 1201, OfferedQtyTo = 3200, SampleSize=125},
                    new QCRageDTO{ AllowMajorDefect=10,OfferedQtyFrom = 3201, OfferedQtyTo = 10000, SampleSize=200},
                    new QCRageDTO{ AllowMajorDefect=14,OfferedQtyFrom = 10001, OfferedQtyTo = 35000, SampleSize=315},
                    new QCRageDTO{ AllowMajorDefect=21,OfferedQtyFrom = 35001, OfferedQtyTo = 150000 , SampleSize=500},
                    new QCRageDTO{ AllowMajorDefect=21,OfferedQtyFrom = 150001, OfferedQtyTo = 500000 , SampleSize=800},
                    new QCRageDTO{ AllowMajorDefect=21,OfferedQtyFrom = 500001 , OfferedQtyTo = 99999999, SampleSize=1250},

                })
                },
                new AQLLib { Id = Guid.Parse("7680f05d-5794-454c-85b1-2291e4882828"), Description = "AQL 2.5 level II", RatingMajor = 1, RatingMinor = 2, CreateDate = DateTime.Now, UpdateDate = DateTime.Now,
                    QCRagesJson = JsonSerializer.Serialize(new List<QCRageDTO> {
                    new QCRageDTO{ AllowMajorDefect=0,OfferedQtyFrom = 2, OfferedQtyTo = 8, SampleSize=2},
                    new QCRageDTO{ AllowMajorDefect=0,OfferedQtyFrom = 9, OfferedQtyTo = 15, SampleSize=3},
                    new QCRageDTO{ AllowMajorDefect=0,OfferedQtyFrom = 16, OfferedQtyTo = 25, SampleSize=5},
                    new QCRageDTO{ AllowMajorDefect=0,OfferedQtyFrom = 26, OfferedQtyTo = 50, SampleSize=8},
                    new QCRageDTO{ AllowMajorDefect=1,OfferedQtyFrom = 51, OfferedQtyTo = 90, SampleSize=13},
                    new QCRageDTO{ AllowMajorDefect=1,OfferedQtyFrom = 91, OfferedQtyTo = 150, SampleSize=20},
                    new QCRageDTO{ AllowMajorDefect=1,OfferedQtyFrom = 151, OfferedQtyTo = 280, SampleSize=32},
                    new QCRageDTO{ AllowMajorDefect=2,OfferedQtyFrom = 281, OfferedQtyTo = 500, SampleSize=50},
                    new QCRageDTO{ AllowMajorDefect=3,OfferedQtyFrom = 501, OfferedQtyTo = 1200 , SampleSize=80},
                    new QCRageDTO{ AllowMajorDefect=5,OfferedQtyFrom = 1201, OfferedQtyTo = 3200, SampleSize=125},
                    new QCRageDTO{ AllowMajorDefect=7,OfferedQtyFrom = 3201, OfferedQtyTo = 10000 , SampleSize=200},
                    new QCRageDTO{ AllowMajorDefect=10,OfferedQtyFrom = 10001, OfferedQtyTo = 35000, SampleSize=315},
                    new QCRageDTO{ AllowMajorDefect=14,OfferedQtyFrom = 35001, OfferedQtyTo = 150000 , SampleSize=500},
                    new QCRageDTO{ AllowMajorDefect=21,OfferedQtyFrom = 150001, OfferedQtyTo = 500000 , SampleSize=800},
                    new QCRageDTO{ AllowMajorDefect=21,OfferedQtyFrom = 500001 , OfferedQtyTo = 99999999, SampleSize=1250},
                })
                }
            );

            builder.Entity<DefectLib>().HasData(defectLibs);

            builder.Entity<QCRequest>().HasData(qcrequests);
            builder.Entity<QCDetail>().HasData(qcdetails);

            // builder.Entity<Defect>().HasData(GenFakeQCTicket(5));
            return builder;
        }

        private static CuttingTableLib[] SeedCuttingTable(int num = 5)
        {
            return Enumerable.Range(0, num).Select(i => new CuttingTableLib { Id = Guid.NewGuid(), Code = $"CuttingTable_Code_{i + 1}", Name = $"CuttingTable_Name_{i + 1}" }).ToArray();
        }

        private static DepartmentLib[] SeedDepartment(int num = 5)
        {
            return Enumerable.Range(0, num).Select(i => new DepartmentLib { Id = Guid.NewGuid(), Code = $"Department_Code_{i + 1}", Name = $"Department_Name_{i + 1}" }).ToArray();
        }

        private static SiteLib[] SeedSiteLib(int num = 5)
        {
            return Enumerable.Range(0, num).Select(i => new SiteLib { Id = Guid.NewGuid(), Code = $"Code_{i + 1}", Name = $"Name_{i + 1}" }).ToArray();
        }

        private static QCZoneTypeLib[] SeedZoneTypeLib()
        {
            return new QCZoneTypeLib[] {
            new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group1, Id = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Code = "M", Name = "Fabric Has Roll (Materials)", Description = "kho v???i c?? roll", CreateDate = DateTime.Now, UpdateDate = DateTime.Now   ,
                    No=1,
                    Prefix = "M",
                    FormsJson = JsonSerializer.Serialize(new FormLibDTO
                    {
                        FilterForm = new Dictionary<string, bool> {
                            {"QCReqNo", true},
                            {"OCNo",    false},
                            {"Buyer",   false},
                            {"GRNNo",   true},
                            {"PONo",    true}
                        }
                    })
                },
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group2, Id = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Code = "N", Name = "Fabric Non Roll (Trims)", Description = "kho v???i kh??ng roll", CreateDate = DateTime.Now, UpdateDate = DateTime.Now,
                    No=2,
                    Prefix = "M",
                    FormsJson = JsonSerializer.Serialize(new FormLibDTO
                    {
                        FilterForm = new Dictionary<string, bool> {
                            {"QCReqNo",true},
                            {"OCNo",    false},
                            {"Buyer",   false},
                            {"GRNNo",   true},
                            {"PONo",    true}
                        }
                    }) },

                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group2, Id = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Code = "T", Name = "Trims", Description = "kho nguy??n ph??? li???u (TRIMS)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now          ,
                    No=3,
                    Prefix = "T",
                    FormsJson = JsonSerializer.Serialize(new FormLibDTO
                    {
                        FilterForm = new Dictionary<string, bool> {
                            {"QCReqNo",true},
                            {"OCNo",    false},
                            {"Buyer",   false},
                            {"GRNNo",   true},
                            {"PONo",    true}}
                    })    },

                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Code = "C", Name = "Cut Operation", Description = "c??ng ??o???n c???t (CUT)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now ,
                    No=4,
                    Prefix = "C",
                    FormsJson = JsonSerializer.Serialize(new FormLibDTO
                    {
                        FilterForm = new Dictionary<string, bool> {
                            {"QCReqNo",true},
                            {"OCNo",    true},
                            {"Buyer",   true},
                            {"GRNNo",   true},
                            {"PONo",    false}
                        }
                    })
                },

                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Code = "PRI", Name = "Print Operation", Description = "c??ng ??o???n in (WASH)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now ,
                    No=5,
                    Prefix = "R",
                    FormsJson = JsonSerializer.Serialize(new FormLibDTO
                    {
                        FilterForm = new Dictionary<string, bool> {
                            {"QCReqNo",true},
                            {"OCNo",    true},
                            {"Buyer",   true},
                            {"GRNNo",   true},
                            {"PONo",    false}
                        }
                    })
                },


                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("de72a6a9-bd09-48e3-b48e-19494d3ddb43"), Code = "EMB", Name = "Emboidery Operation", Description = "c??ng ??o???n th??u (EMBOIDERY)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now,
                    No=6,
                    Prefix = "E",
                    FormsJson = JsonSerializer.Serialize(new FormLibDTO
                    {
                        FilterForm = new Dictionary<string, bool> {
                            {"QCReqNo",true},
                            {"OCNo",    true},
                            {"Buyer",   true},
                            {"GRNNo",   true},
                            {"PONo",    false}
                        }
                    })
                },

                
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Code = "SEW", Name = "Sew Operation", Description = "c??ng ??o???n may (SEW)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now,
                    No=7,
                    Prefix = "S",
                    FormsJson = JsonSerializer.Serialize(new FormLibDTO
                    {
                        FilterForm = new Dictionary<string, bool> {
                            {"QCReqNo",true},
                            {"OCNo",    true},
                            {"Buyer",   true},
                            {"GRNNo",   true},
                            {"PONo",    false}
                        }
                    })
                },

                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Code = "WASH", Name = "Wash Operation", Description = "c??ng ??o???n wash (SEND TO FINISH)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now,
                    No=8,
                    Prefix = "W",
                    FormsJson = JsonSerializer.Serialize(new FormLibDTO
                    {
                        FilterForm = new Dictionary<string, bool> {
                            {"QCReqNo",true},
                            {"OCNo",    true},
                            {"Buyer",   true},
                            {"GRNNo",   true},
                            {"PONo",    false}
                        }
                    })
                },
                new QCZoneTypeLib
                {
                    GroupType = QCZoneTypeGroupEnum.Group3,
                    Id = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"),
                    Code = "PCK",
                    Name = "Packing Operation",
                    Description = "c??ng ??o???n ho??n t???t (PACKING)",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    No=9,
                    Prefix = "F",
                    FormsJson = JsonSerializer.Serialize(new FormLibDTO
                    {
                        FilterForm = new Dictionary<string, bool> {
                            {"QCReqNo",false},
                            {"OCNo",    true},
                            {"Buyer",   true},
                            {"GRNNo",   false},
                            {"PONo",    false}
                        }
                    })
                },
                new QCZoneTypeLib
                {
                    GroupType = QCZoneTypeGroupEnum.Group4,
                    Id = Guid.Parse("c414c4a2-eca1-4cc3-b598-99d7f1c5b1ec"),
                    Code = "PRF",
                    Name = "Pre-Final",
                    Description = "Pre-Final",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    No = 10,
                    Prefix = "V",
                    FormsJson = JsonSerializer.Serialize(new FormLibDTO
                    {
                        FilterForm = new Dictionary<string, bool> {
                            {"QCReqNo",false},
                            {"OCNo",    true},
                            {"Buyer",   true},
                            {"GRNNo",   false},
                            {"PONo",    false}
                        }
                    })
                },
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group4, Id = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Code = "FINAL", Name = "Final", Description = "Final", CreateDate = DateTime.Now, UpdateDate = DateTime.Now,
                    No = 11,
                    Prefix = "P",
                    FormsJson = JsonSerializer.Serialize(new FormLibDTO
                    {
                        FilterForm = new Dictionary<string, bool> {
                            {"QCReqNo",false},
                            {"OCNo",    true},
                            {"Buyer",   true},
                            {"GRNNo",   false},
                            {"PONo",    false}
                        }
                    })
                }
            };
        }

        private static DefectLib[] SeedDefectLib()
        {
            return new DefectLib[] {
            new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M01", Name = "?????T S???I D???C", Description = "BROKEN END", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M02", Name = "?????T S???I NGANG", Description = "BROKEN PICK", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M03", Name = "S???I TH?? D???C", Description = "COARSE END ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M04", Name = "S???I TH?? NGANG", Description = "COARSE PICK ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M05", Name = "S???I T???P", Description = "FOREIGN FIBER ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M06", Name = "BI???N M??U /D??", Description = "STAIN / DIRTY ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M07", Name = "?????M M??U", Description = "COLOR / WHITE SPOT", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M08", Name = "N???I S???I , B??NG T???P", Description = " KNOT/NAP ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M09", Name = "L???NG S???I D???C", Description = "LOOSE WARP ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M10", Name = "M???T S???I NGANG", Description = "MISPICK", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M11", Name = "D???NG M??Y", Description = "STOP MARK", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M12", Name = "G??Y M???T V???I", Description = "CREASE MARK ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M13", Name = "TH???NG", Description = " HOLE ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M14", Name = "IN L??CH KHU??N", Description = "Print off layout ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M15", Name = "IN LEM M??U", Description = " PRINT COLOR SMEAR", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M16", Name = "Kh??c m??u bi??n ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M17", Name = "kh??c m??u ?????u cu???i", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M18", Name = "S???c ngang, d???c, s???c nhu???m", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M19", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M20", Name = "Nh???ng l???i kh??c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO01", Name = "?????T S???I D???C", Description = "BROKEN END", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO02", Name = "?????T S???I NGANG", Description = "BROKEN PICK", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO03", Name = "S???I TH?? D???C", Description = "COARSE END ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO04", Name = "S???I TH?? NGANG", Description = "COARSE PICK ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO05", Name = "S???I T???P", Description = "FOREIGN FIBER ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO06", Name = "BI???N M??U /D??", Description = "STAIN / DIRTY ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO07", Name = "?????M M??U", Description = "COLOR / WHITE SPOT", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO08", Name = "N???I S???I , B??NG T???P", Description = " KNOT/NAP ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO09", Name = "L???NG S???I D???C", Description = "LOOSE WARP ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO10", Name = "M???T S???I NGANG", Description = "MISPICK", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO11", Name = "D???NG M??Y", Description = "STOP MARK", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO12", Name = "G??Y M???T V???I", Description = "CREASE MARK ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO13", Name = "TH???NG", Description = " HOLE ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO14", Name = "IN L??CH KHU??N", Description = "Print off layout ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO15", Name = "IN LEM M??U", Description = " PRINT COLOR SMEAR", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO16", Name = "Kh??c m??u bi??n ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO17", Name = "kh??c m??u ?????u cu???i", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO18", Name = "S???c ngang, d???c, s???c nhu???m", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO19", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO20", Name = "Nh???ng l???i kh??c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T01", Name = "Sai t??? ng???, k?? hi???u, Logo,..", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T02", Name = "Sai ch???ng lo???i, ch???t li???u, h??nh d???ng, k??ch th?????c, m??u s???c,..", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T03", Name = "N??t ch??? tr??n ph??? li???u kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T04", Name = "Ph??? li???u kh??ng an to??n khi s??? d???ng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T05", Name = "Ph??? li???u kim lo???i r?? kim kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T06", Name = "Ph??? li???u  n???t, l???ng r??ch, bi???n d???ng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T07", Name = "????? m???m ph??? li???u, ???m/m???c, m??i h??i", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T08", Name = "Ph??? li???u g??? s??t, tr???y x?????c b??? m???t, tr??c in, d??", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T09", Name = "Loang m??u, ?????i m??u, kh??ng ?????ng m??u trong l??", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T10", Name = "?????u v?? r??ng kh??a d??y k??o kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T11", Name = "????? tr?????t kh??a k??o kh??ng ?????t", Description = "k??o tr?????t 10 l???n", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T12", Name = "V???n, xo???n, c?? nhi???u m???i n???i", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T13", Name = "M???i d??n ??p bao b?? kh??ng b???n ch???c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T14", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T15", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T16", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T17", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T18", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T19", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T20", Name = "Nh???ng l???i kh??c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C01", Name = "L???i ho???c sai s?? ????? c???t, r???p c???ng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C02", Name = "B??n th??nh ph???m c???t l???n ho???c nh??? h??n r???p ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C03", Name = "Bi???n d???ng, sai h??nh d??ng, canh s???i, b??? m???t", Description = "v???i ch??nh, v???i l??t, keo,???", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C04", Name = "Thi???u d???u b???m, d???u b???m ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C05", Name = "L???i ????nh s???", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C06", Name = "Loang m??u chi ti???t, d??, ???", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C07", Name = "??p keo kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C08", Name = "Sai m??u th??u, m??u in", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C09", Name = "In, th??u thi???u n??t, thi???u ch???", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C10", Name = "In, th??u sai v??? tr??", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C11", Name = "Th??u b??? m??i, ?????t ch???, kh??ng kh??a m??i", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C12", Name = "L???ng r??ch b??n th??nh ph???m v???i/ keo", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C13", Name = "L???i v???i", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C14", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C15", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C16", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C17", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C18", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C19", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C20", Name = "Nh???ng l???i kh??c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S01", Name = "N???i ch??? kh??ng tr??ng, ch??? th???a, l??? ch??? l?????c, v??? sinh c??ng nghi???p kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S02", Name = "Bung ch???, ?????t ch???, b??? m??i, c??ng ch???, l???ng ch???", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S03", Name = "Nh??n nh??u, v???n, g???n s??ng, bai gi??n, s???p m??, le m??, x?? m??p,x???p ly", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S04", Name = "Cao/th???p, kh??ng ?????ng ?????u ???????ng may, kh??ng ?????i x???ng, kh??ng ????ng d???u/r???p", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S05", Name = "L???ng, r??ch, l??? kim", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S06", Name = "D??nh g???-s??t, d???u m??y", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S07", Name = "D??, d???u ph???n, m???c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S08", Name = "Kh??c m??u chi ti???t, r??p l???n s???", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S09", Name = "L???i ???i", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S10", Name = "L???i k??? thu???t, bi???n d???ng form, kh??ng ph?? h???p,..", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S11", Name = "Thi???u/ Sai: Ph??? li???u, nh??n, b??n th??nh ph???m In, th??u", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S12", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S13", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S14", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S15", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S16", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S17", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S18", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S19", Name = "L???i th??ng s???", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S20", Name = "Nh???ng l???i kh??c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W01", Name = "??nh m??u kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W02", Name = "Kh??c m??u, loang m??u trong c??ng s???n ph???m", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W03", Name = "PP kh??ng ?????t, ?????m PP, c???n wash", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W04", Name = "Hi???u ???ng th???i trang kh??ng ?????t", Description = "whishkers, grinding,..", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W05", Name = "H??nh d??ng, k??ch th?????c, v??? tr?? th???i trang wash kh??ng ????ng", Description = " handsands, destroys,..", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W06", Name = "3D thi???u ho???c m???nh/y???u", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W07", Name = "C???n wash, ?????m", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W08", Name = "????? m???m kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W09", Name = "Hi???u ???ng wash, nhu???m kh??ng ?????ng ?????u", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W10", Name = "M??i h??i, ???m m???c, m???c r??ch", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W11", Name = "L???i V???i", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W12", Name = "L???i May", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W13", Name = "L???i d??", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W14", Name = "Nh??n/ g??y, s???n ho???c c???n b??ng b??? m???t v???i", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W15", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W16", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W17", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W18", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W19", Name = "L???i th??ng s???", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W20", Name = "Nh???ng l???i kh??c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F01", Name = "V??? sinh c??ng nghi???p, ch??? th???a kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F02", Name = "D??nh d???u m??y, d??, d???u ph???n, d???u m???c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F03", Name = "???i (l??) x???u, b??? b??ng, ch??y n??m, bi???n d???ng Form", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F04", Name = "????ng (????nh) n??t, rivet, ph??? li???u,??? kh??ng ?????t b???n ch???c, kh??ng an to??n khi s??? d???ng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F05", Name = "????ng (????nh) n??t, rivet,  ???i, g???n nh??n, g???p x???p,... sai quy c??ch; thi???u/ d?? ph??? li???u", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F06", Name = "S??? d???ng sai ph??? li???u", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F07", Name = "L???ng, r??ch, l??? kim", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F08", Name = "Bung ch???, bung ???????ng may, ?????t ch???, b??? m??i, c??ng ch???, l???ng ch???, n???i ch??? kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F09", Name = "Nh??n nh??u, x???p ly, s???p m??, g???n s??ng, v???n ???????ng may, v??n canh v???i, bai gi??n", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F10", Name = "D?? kim lo???i kh??ng ?????t ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F11", Name = "C???n wash, ?????m wash", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F12", Name = "Hi???u ???ng, th???i trang wash ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F13", Name = "G???p x???p, d??n th??ng, ??ai th??ng kh??ng ?????t ch???t l?????ng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F14", Name = "Sai t??? l??? v?? s??? l?????ng trong th??ng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F15", Name = "M??i h??i, ???m m???c, m???c v???i, v???t l??? tr??n s???n ph???m", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F16", Name = "Ch???t l?????ng ph??? li???u kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F17", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F18", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F19", Name = "L???i th??ng s???", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F20", Name = "Nh???ng l???i kh??c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP01", Name = "V??? sinh c??ng nghi???p, ch??? th???a kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP02", Name = "D??nh d???u m??y, d??, d???u ph???n, d???u m???c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP03", Name = "???i (l??) x???u, b??? b??ng, ch??y n??m, bi???n d???ng Form", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP04", Name = "????ng (????nh) n??t, rivet, ph??? li???u,??? kh??ng ?????t b???n ch???c, kh??ng an to??n khi s??? d???ng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP05", Name = "????ng (????nh) n??t, rivet,  ???i, g???n nh??n, g???p x???p,... sai quy c??ch; thi???u/ d?? ph??? li???u", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP06", Name = "S??? d???ng sai ph??? li???u", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP07", Name = "L???ng, r??ch, l??? kim", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP08", Name = "Bung ch???, bung ???????ng may, ?????t ch???, b??? m??i, c??ng ch???, l???ng ch???, n???i ch??? kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP09", Name = "Nh??n nh??u, x???p ly, s???p m??, g???n s??ng, v???n ???????ng may, v??n canh v???i, bai gi??n", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP10", Name = "??nh m??u kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP11", Name = "C???n wash, ?????m wash", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP12", Name = "Hi???u ???ng wash, nhu???m kh??ng ?????ng ?????u", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP13", Name = "H??nh d??ng, k??ch th?????c, v??? tr?? th???i trang wash kh??ng ????ng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP14", Name = "Sai s??? l?????ng v?? t??? l??? trong th??ng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP15", Name = "M??i h??i, ???m m???c, m???c v???i, v???t l??? tr??n s???n ph???m", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP16", Name = "M???c th??? kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP17", Name = "K??? thu???t may x???u, kh??ng ph?? h???p", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP18", Name = "Ch???t l?????ng ph??? li???u kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP19", Name = "L???i Th??ng s???", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP20", Name = "Nh???ng l???i kh??c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P01", Name = "V??? sinh c??ng nghi???p, ch??? th???a kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P02", Name = "D??nh d???u m??y, d??, d???u ph???n, d???u m???c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P03", Name = "???i (l??) x???u, b??? b??ng, ch??y n??m, bi???n d???ng Form", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P04", Name = "????ng (????nh) n??t, rivet, ph??? li???u,??? kh??ng ?????t b???n ch???c, kh??ng an to??n khi s??? d???ng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P05", Name = "????ng (????nh) n??t, rivet,  ???i, g???n nh??n, g???p x???p,... sai quy c??ch; thi???u/ d?? ph??? li???u", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P06", Name = "S??? d???ng sai ph??? li???u", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P07", Name = "L???ng, r??ch, l??? kim", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P08", Name = "Bung ch???, bung ???????ng may, ?????t ch???, b??? m??i, c??ng ch???, l???ng ch???, n???i ch??? kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P09", Name = "Nh??n nh??u, x???p ly, s???p m??, g???n s??ng, v???n ???????ng may, v??n canh v???i, bai gi??n", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P10", Name = "??nh m??u kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P11", Name = "C???n wash, ?????m wash", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P12", Name = "Hi???u ???ng wash, nhu???m kh??ng ?????ng ?????u", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P13", Name = "H??nh d??ng, k??ch th?????c, v??? tr?? th???i trang wash kh??ng ????ng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P14", Name = "Sai s??? l?????ng v?? t??? l??? trong th??ng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P15", Name = "M??i h??i, ???m m???c, m???c v???i, v???t l??? tr??n s???n ph???m", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P16", Name = "M???c th??? kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P17", Name = "K??? thu???t may x???u, kh??ng ph?? h???p", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P18", Name = "Ch???t l?????ng ph??? li???u kh??ng ?????t", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P19", Name = "L???i Th??ng s???", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P20", Name = "Nh???ng l???i kh??c", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now }

            };
        }


        private static QCRequest[] SeedQCRequest(QCZoneTypeLib[] zoneTypes, int v=1, int sizeNum = 5)
        {
            var n = v < 1 ? 1 : v;
            var result = Enumerable.Range(0, n).Select(i =>
            {
                var e = i + 1;
                var zoneType = zoneTypes[e % zoneTypes.Count()];
                
                var data = new QCRequest
                {
                    Id = Ids[i],
                    Description= "Description",
                    TransferStatus = TransferStatusEnum.NotTransfered,
                    DocStatus = DocStatusEnum.Inprogress,
                    Site = $"Site-{(e%5)+1}",
                    Buyer = $"Buyer-{(e % 20) + 1}",
                    Supplier = $"Buyer-{(e % 20) + 1}",
                    QCNumber = $"QCNumber-{e}",
                    GRNNumber = $"GRNNumber-{e}",
                    PONo = $"PONo-{e}",
                    OCNumber = $"OCNumber-{e}",
                    Category = $"Category-{e}",
                    ArticleName = $"ArticleName-{e}",
                    StyleName = $"StyleName-{e}",
                    QCDefinition = $"QCDefinition-{e}",
                    SamplePlan = $"SamplePlan-{e}",
                    DeliveryBuyerOrderRef = $"DeliveryBuyerOrderRef-{e}",
                    ArticleCode = $"ArticleCode-{e}",
                    StyleCode = $"StyleCode-{e}",
                    ColorCode = $"ColorCode-{e}",
                    ColorName = $"ColorName-{e}",
                    QCType = $"QCType-{e}",
                    GRNQty =100*(e%5+1),
                    DefectResult = e % 2 == 0,
                    FinalResult = e % 2 != 0,
                    QCRequestDate = DateTime.Now,
                    QCQty = e,
                    SamplePercentage = e*10,
                    SizeBreakDownsJson = JsonSerializer.Serialize(Enumerable.Range(0, sizeNum).Select(j=> {
                        var size = new SizeBreakDownDTO {
                            SizeCode = $"SizeCode-{j + 1}",
                            SizeName = $"SizeName-{j + 1}",
                            Shade = $"Shade-{j + 1}",
                            QCQty = j + 1,
                            InspectionQty = j + 1
                        };
                        return size;
                    })),
                    ZoneTypeId = zoneType.Id,
                    ZoneType = zoneType
                };
                return data;
            }).ToArray();

                return result;
        }

        private static QCDetail[] SeedQCDetail(QCRequest[] qcrequests, DefectLib[] defectLibs, int childNum = 5)
        {
            var count = 0;
            var result = qcrequests.Select(x =>
            {
                var id = Ids[count];
                var zoneType = x.ZoneType;
                var defects = defectLibs.Where(x => x.ZoneTypeId == zoneType.Id);

                bool isFinal = zoneType.Code == "P" || zoneType.Code == "V";

                var d = new QCDetail
                {
                    Id = id,
                    Code = $"code_{count + 1}",
                    Name = $"name_{count + 1}",
                    ProductLine = $"ProductLine_{(count) % 5 + 1}",
                    InspectionBySizesJson = isFinal ? string.Empty : JsonSerializer.Serialize(
                        x.SizeBreakDowns.Select(sz => new InspectionBySizeDTO
                        {
                            ColorCode = x.ColorCode,
                            SizeCode = sz.SizeCode,
                            Qty = sz.QCQty,
                            BGroupQty = 1,
                            RejectQty = 1,
                            OkQty = sz.QCQty - 1 - 1
                        })),
                    InspectionBySizesFinalJson = !isFinal ? string.Empty : JsonSerializer.Serialize(
                        x.SizeBreakDowns.Select(sz => new InspectionBySizeFinalDTO
                        {
                            OCNumber = $"OCNumber Sub",
                            Size = sz.SizeCode,
                            Color = x.ColorCode,
                            OrderQty = 2000,
                            OfferedQty = 1000,
                            InspectionQty = 300,
                            AcceptedQty = 280
                        })),
                    DefectDetailJson = JsonSerializer.Serialize(
                        new DefectDetailDTO
                        {
                            AQLId = !isFinal ? Guid.Parse("94d900ec-0757-4a06-815d-096bc27b7fb7") : Guid.Parse("9f6f0a5a-900e-44b0-9fb7-dbe1dd1aed66"),
                            Defects = defects.Select(x => new DefectDTO { Code = x.Code, Description = x.Description, Critical = 0, Minor = count % 2, Major = count % 2, Comment = "Anh th???t s??? ngu ng???c!" }).ToList()
                        }),
                    InspectionQty = 100 * (count % childNum),
                    MeasurementQty = 100 * (count % childNum),
                    PrivateDetailJson = JsonSerializer.Serialize(new { Private1 = "private1", Private2 = "private2" })
                };
                count++;

                return d;
            });
            return result.ToArray();
        }

        //private static IEnumerable<QCDetail> SeedQCDetailWithZoneIsFinal(IEnumerable<QCRequest> qcrequests, QCZoneTypeLib[] zoneTypes, int childNum=5)
        //{
        //    var defects = SeedDefectLib().Where(x => x.ZoneTypeId == qcrequests.FirstOrDefault().ZoneTypeId);
        //    var count = 0;
        //    return qcrequests.Select(x => {
        //        var id = Ids[count];
        //        count++;
        //        var zoneType = zoneTypes[count % zoneTypes.Count()];
        //        bool isPreFinal = zoneType.Code == "PREF";
        //        var d = new QCDetail
        //        {
        //            Id = id,
        //            Code = $"code_{count+1}",
        //            Name = $"name_{count+1}",
        //            ProductLine = $"ProductLine_{(count)%5+1}",
        //            InspectionBySizesJson = isPreFinal?string.Empty:JsonSerializer.Serialize(
        //                x.SizeBreakDowns.Select(sz => new InspectionBySizeDTO {
        //                    ColorCode = x.ColorCode,
        //                    SizeCode = sz.SizeCode,
        //                    Qty = sz.QCQty,
        //                    BGroupQty = 1,
        //                    RejectQty = 1,
        //                    OkQty = sz.QCQty - 1 - 1
        //                })),
        //            InspectionBySizesFinalJson = !isPreFinal?string.Empty: JsonSerializer.Serialize(
        //                x.SizeBreakDowns.Select(sz => new InspectionBySizeFinalDTO
        //                {
        //                    OCNumber = $"OCNumber Sub",
        //                    Size = sz.SizeCode,
        //                    Color = x.ColorCode,
        //                    OrderQty = 2000,
        //                    OfferedQty = 1000,
        //                    InspectionQty = 300,
        //                    AcceptedQty = 280
        //                })),
        //            DefectDetailJson = JsonSerializer.Serialize(
        //                new DefectDetailDTO { AQLId = Guid.Parse("9f6f0a5a-900e-44b0-9fb7-dbe1dd1aed66"),
        //                    Defects = defects.Select(x => new DefectDTO { Code = x.Code,Description=x.Description, Critical = 0, Minor =count%2, Major = count % 2 }).ToList()
        //                }),
        //            InspectionQty = 100*(count%childNum),
        //            MeasurementQty= 100 * (count % childNum),
        //            PrivateDetailJson = JsonSerializer.Serialize(new { Private1 = "private1", Private2 = "private2" }),
        //        };
        //        return d;
        //        });
        //}

        public static void SeedFakeData(this QCContext context)
        {
            if (!context.QCDetail.Any())
            {
                Console.WriteLine("====> Seeding fake data ...");
                context.AddRange(
                    new QCDetail { Id = Guid.NewGuid(), Code = "Code_1", Name = "QCTicket Name 1" },
                    new QCDetail { Id = Guid.NewGuid(), Code = "Code_2", Name = "QCTicket Name 2" },
                    new QCDetail { Id = Guid.NewGuid(), Code = "Code_3", Name = "QCTicket Name 3" }
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