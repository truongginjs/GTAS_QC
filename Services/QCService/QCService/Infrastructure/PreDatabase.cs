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
            new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group1, Id = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Code = "M", Name = "Fabric Has Roll (Materials)", Description = "kho vải có roll", CreateDate = DateTime.Now, UpdateDate = DateTime.Now   ,
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
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group2, Id = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Code = "N", Name = "Fabric Non Roll (Trims)", Description = "kho vải không roll", CreateDate = DateTime.Now, UpdateDate = DateTime.Now,
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

                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group2, Id = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Code = "T", Name = "Trims", Description = "kho nguyên phụ liệu (TRIMS)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now          ,
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

                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Code = "C", Name = "Cut Operation", Description = "công đoạn cắt (CUT)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now ,
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

                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Code = "PRI", Name = "Print Operation", Description = "công đoạn in (WASH)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now ,
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


                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("de72a6a9-bd09-48e3-b48e-19494d3ddb43"), Code = "EMB", Name = "Emboidery Operation", Description = "công đoạn thêu (EMBOIDERY)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now,
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

                
                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Code = "SEW", Name = "Sew Operation", Description = "công đoạn may (SEW)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now,
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

                new QCZoneTypeLib { GroupType = QCZoneTypeGroupEnum.Group3, Id = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Code = "WASH", Name = "Wash Operation", Description = "công đoạn wash (SEND TO FINISH)", CreateDate = DateTime.Now, UpdateDate = DateTime.Now,
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
                    Description = "công đoạn hoàn tất (PACKING)",
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
            new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M01", Name = "ĐỨT SỢI DỌC", Description = "BROKEN END", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M02", Name = "ĐỨT SỢI NGANG", Description = "BROKEN PICK", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M03", Name = "SỢI THÔ DỌC", Description = "COARSE END ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M04", Name = "SỢI THÔ NGANG", Description = "COARSE PICK ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M05", Name = "SỢI TẠP", Description = "FOREIGN FIBER ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M06", Name = "BIẾN MÀU /DƠ", Description = "STAIN / DIRTY ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M07", Name = "ĐỐM MÀU", Description = "COLOR / WHITE SPOT", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M08", Name = "NỐI SỢI , BÔNG TẠP", Description = " KNOT/NAP ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M09", Name = "LỎNG SỢI DỌC", Description = "LOOSE WARP ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M10", Name = "MẤT SỢI NGANG", Description = "MISPICK", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M11", Name = "DỪNG MÁY", Description = "STOP MARK", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M12", Name = "GÃY MẶT VẢI", Description = "CREASE MARK ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M13", Name = "THỦNG", Description = " HOLE ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M14", Name = "IN LÊCH KHUÔN", Description = "Print off layout ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M15", Name = "IN LEM MÀU", Description = " PRINT COLOR SMEAR", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M16", Name = "Khác màu biên ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M17", Name = "khác màu đầu cuối", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M18", Name = "Sọc ngang, dọc, sọc nhuộm", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M19", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), Id = Guid.NewGuid(), Code = "M20", Name = "Những lỗi khác", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO01", Name = "ĐỨT SỢI DỌC", Description = "BROKEN END", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO02", Name = "ĐỨT SỢI NGANG", Description = "BROKEN PICK", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO03", Name = "SỢI THÔ DỌC", Description = "COARSE END ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO04", Name = "SỢI THÔ NGANG", Description = "COARSE PICK ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO05", Name = "SỢI TẠP", Description = "FOREIGN FIBER ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO06", Name = "BIẾN MÀU /DƠ", Description = "STAIN / DIRTY ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO07", Name = "ĐỐM MÀU", Description = "COLOR / WHITE SPOT", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO08", Name = "NỐI SỢI , BÔNG TẠP", Description = " KNOT/NAP ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO09", Name = "LỎNG SỢI DỌC", Description = "LOOSE WARP ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO10", Name = "MẤT SỢI NGANG", Description = "MISPICK", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO11", Name = "DỪNG MÁY", Description = "STOP MARK", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO12", Name = "GÃY MẶT VẢI", Description = "CREASE MARK ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO13", Name = "THỦNG", Description = " HOLE ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO14", Name = "IN LÊCH KHUÔN", Description = "Print off layout ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO15", Name = "IN LEM MÀU", Description = " PRINT COLOR SMEAR", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO16", Name = "Khác màu biên ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO17", Name = "khác màu đầu cuối", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO18", Name = "Sọc ngang, dọc, sọc nhuộm", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO19", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("63892f60-c8cb-40de-b365-e52f66a04ec4"), Id = Guid.NewGuid(), Code = "MO20", Name = "Những lỗi khác", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T01", Name = "Sai từ ngữ, ký hiệu, Logo,..", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T02", Name = "Sai chủng loại, chất liệu, hình dạng, kích thước, màu sắc,..", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T03", Name = "Nét chữ trên phụ liệu không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T04", Name = "Phụ liệu không an toàn khi sử dụng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T05", Name = "Phụ liệu kim loại rà kim không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T06", Name = "Phụ liệu  nứt, lủng rách, biến dạng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T07", Name = "Độ mềm phụ liệu, ẩm/mốc, mùi hôi", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T08", Name = "Phụ liệu gỉ sét, trầy xước bề mặt, tróc in, dơ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T09", Name = "Loang màu, đổi màu, không đồng màu trong lô", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T10", Name = "Đầu và răng khóa dây kéo không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T11", Name = "Độ trượt khóa kéo không đạt", Description = "kéo trượt 10 lần", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T12", Name = "Vặn, xoắn, có nhiều mối nối", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T13", Name = "Mối dán ép bao bì không bền chắc", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T14", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T15", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T16", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T17", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T18", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T19", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("f34e7928-c4f0-4f84-95f7-335d73196358"), Id = Guid.NewGuid(), Code = "T20", Name = "Những lỗi khác", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C01", Name = "Lỗi hoặc sai sơ đồ cắt, rập cứng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C02", Name = "Bán thành phẩm cắt lớn hoặc nhỏ hơn rập ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C03", Name = "Biến dạng, sai hình dáng, canh sợi, bề mặt", Description = "vải chính, vải lót, keo,…", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C04", Name = "Thiếu dấu bấm, dấu bấm ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C05", Name = "Lỗi đánh số", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C06", Name = "Loang màu chi tiết, dơ, ố", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C07", Name = "Ép keo không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C08", Name = "Sai màu thêu, màu in", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C09", Name = "In, thêu thiếu nét, thiếu chữ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C10", Name = "In, thêu sai vị trí", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C11", Name = "Thêu bỏ mũi, đứt chỉ, không khóa mũi", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C12", Name = "Lủng rách bán thành phẩm vải/ keo", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C13", Name = "Lỗi vải", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C14", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C15", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C16", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C17", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C18", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C19", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), Id = Guid.NewGuid(), Code = "C20", Name = "Những lỗi khác", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S01", Name = "Nối chỉ không trùng, chỉ thừa, lộ chỉ lược, vệ sinh công nghiệp không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S02", Name = "Bung chỉ, đứt chỉ, bỏ mũi, căng chỉ, lỏng chỉ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S03", Name = "Nhăn nhíu, vặn, gợn sóng, bai giãn, sụp mí, le mí, xì mép,xếp ly", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S04", Name = "Cao/thấp, không đồng đều đường may, không đối xứng, không đúng dấu/rập", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S05", Name = "Lủng, rách, lỗ kim", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S06", Name = "Dính gỉ-sét, dầu máy", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S07", Name = "Dơ, dấu phấn, mực", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S08", Name = "Khác màu chi tiết, ráp lộn số", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S09", Name = "Lỗi ủi", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S10", Name = "Lỗi kỹ thuật, biến dạng form, không phù hợp,..", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S11", Name = "Thiếu/ Sai: Phụ liệu, nhãn, bán thành phẩm In, thêu", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S12", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S13", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S14", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S15", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S16", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S17", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S18", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S19", Name = "Lỗi thông số", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("ca691bec-ae50-4884-9e5e-7e6f84b24087"), Id = Guid.NewGuid(), Code = "S20", Name = "Những lỗi khác", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W01", Name = "Ánh màu không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W02", Name = "Khác màu, loang màu trong cùng sản phẩm", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W03", Name = "PP không đạt, đốm PP, cấn wash", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W04", Name = "Hiệu ứng thời trang không đạt", Description = "whishkers, grinding,..", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W05", Name = "Hình dáng, kích thước, vị trí thời trang wash không đúng", Description = " handsands, destroys,..", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W06", Name = "3D thiếu hoặc mạnh/yếu", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W07", Name = "Cấn wash, đốm", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W08", Name = "Độ mềm không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W09", Name = "Hiệu ứng wash, nhuộm không đồng đều", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W10", Name = "Mùi hôi, ẩm mốc, mục rách", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W11", Name = "Lỗi Vải", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W12", Name = "Lỗi May", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W13", Name = "Lỗi dơ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W14", Name = "Nhăn/ gãy, sờn hoặc cấn bóng bề mặt vải", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W15", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W16", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W17", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W18", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W19", Name = "Lỗi thông số", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("1bc43632-e605-4489-8030-f7dad305f00c"), Id = Guid.NewGuid(), Code = "W20", Name = "Những lỗi khác", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F01", Name = "Vệ sinh công nghiệp, chỉ thừa không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F02", Name = "Dính dầu máy, dơ, dấu phấn, dấu mực", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F03", Name = "Ủi (là) xấu, bị bóng, cháy nám, biến dạng Form", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F04", Name = "Đóng (đính) nút, rivet, phụ liệu,… không đạt bền chắc, không an toàn khi sử dụng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F05", Name = "Đóng (đính) nút, rivet,  ủi, gắn nhãn, gấp xếp,... sai quy cách; thiếu/ dư phụ liệu", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F06", Name = "Sử dụng sai phụ liệu", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F07", Name = "Lủng, rách, lỗ kim", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F08", Name = "Bung chỉ, bung đường may, đứt chỉ, bỏ mũi, căng chỉ, lỏng chỉ, nối chỉ không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F09", Name = "Nhăn nhíu, xếp ly, sụp mí, gợn sóng, vặn đường may, văn canh vải, bai giãn", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F10", Name = "Dò kim loại không đạt ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F11", Name = "Cấn wash, đốm wash", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F12", Name = "Hiệu ứng, thời trang wash ", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F13", Name = "Gấp xếp, dán thùng, đai thùng không đạt chất lượng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F14", Name = "Sai tỷ lệ và số lượng trong thùng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F15", Name = "Mùi hôi, ẩm mốc, mục vải, vật lạ trên sản phẩm", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F16", Name = "Chất lượng phụ liệu không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F17", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F18", Name = "0", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F19", Name = "Lỗi thông số", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("cd6aac51-979f-499b-a9bc-55681caf2956"), Id = Guid.NewGuid(), Code = "F20", Name = "Những lỗi khác", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP01", Name = "Vệ sinh công nghiệp, chỉ thừa không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP02", Name = "Dính dầu máy, dơ, dấu phấn, dấu mực", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP03", Name = "Ủi (là) xấu, bị bóng, cháy nám, biến dạng Form", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP04", Name = "Đóng (đính) nút, rivet, phụ liệu,… không đạt bền chắc, không an toàn khi sử dụng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP05", Name = "Đóng (đính) nút, rivet,  ủi, gắn nhãn, gấp xếp,... sai quy cách; thiếu/ dư phụ liệu", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP06", Name = "Sử dụng sai phụ liệu", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP07", Name = "Lủng, rách, lỗ kim", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP08", Name = "Bung chỉ, bung đường may, đứt chỉ, bỏ mũi, căng chỉ, lỏng chỉ, nối chỉ không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP09", Name = "Nhăn nhíu, xếp ly, sụp mí, gợn sóng, vặn đường may, văn canh vải, bai giãn", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP10", Name = "Ánh màu không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP11", Name = "Cấn wash, đốm wash", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP12", Name = "Hiệu ứng wash, nhuộm không đồng đều", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP13", Name = "Hình dáng, kích thước, vị trí thời trang wash không đúng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP14", Name = "Sai số lượng và tỷ lệ trong thùng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP15", Name = "Mùi hôi, ẩm mốc, mục vải, vật lạ trên sản phẩm", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP16", Name = "Mặc thử không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP17", Name = "Kỹ thuật may xấu, không phù hợp", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP18", Name = "Chất lượng phụ liệu không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP19", Name = "Lỗi Thông số", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("3fe931f7-728b-48e6-b37c-828f683f9229"), Id = Guid.NewGuid(), Code = "PP20", Name = "Những lỗi khác", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },

new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P01", Name = "Vệ sinh công nghiệp, chỉ thừa không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P02", Name = "Dính dầu máy, dơ, dấu phấn, dấu mực", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P03", Name = "Ủi (là) xấu, bị bóng, cháy nám, biến dạng Form", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P04", Name = "Đóng (đính) nút, rivet, phụ liệu,… không đạt bền chắc, không an toàn khi sử dụng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P05", Name = "Đóng (đính) nút, rivet,  ủi, gắn nhãn, gấp xếp,... sai quy cách; thiếu/ dư phụ liệu", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P06", Name = "Sử dụng sai phụ liệu", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P07", Name = "Lủng, rách, lỗ kim", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P08", Name = "Bung chỉ, bung đường may, đứt chỉ, bỏ mũi, căng chỉ, lỏng chỉ, nối chỉ không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P09", Name = "Nhăn nhíu, xếp ly, sụp mí, gợn sóng, vặn đường may, văn canh vải, bai giãn", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P10", Name = "Ánh màu không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P11", Name = "Cấn wash, đốm wash", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P12", Name = "Hiệu ứng wash, nhuộm không đồng đều", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P13", Name = "Hình dáng, kích thước, vị trí thời trang wash không đúng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P14", Name = "Sai số lượng và tỷ lệ trong thùng", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P15", Name = "Mùi hôi, ẩm mốc, mục vải, vật lạ trên sản phẩm", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P16", Name = "Mặc thử không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P17", Name = "Kỹ thuật may xấu, không phù hợp", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P18", Name = "Chất lượng phụ liệu không đạt", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P19", Name = "Lỗi Thông số", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
new DefectLib { ZoneTypeId = Guid.Parse("7ced9b1f-31ad-4452-a625-81f48afe0e24"), Id = Guid.NewGuid(), Code = "P20", Name = "Những lỗi khác", ReasonsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1}")), SolutionsJson = JsonSerializer.Serialize(Enumerable.Range(0, 5).Select(i => $"Proplem1 reason{i + 1} solution{i + 1}")), CreateDate = DateTime.Now, UpdateDate = DateTime.Now }

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
                            Defects = defects.Select(x => new DefectDTO { Code = x.Code, Description = x.Description, Critical = 0, Minor = count % 2, Major = count % 2, Comment = "Anh thật sự ngu ngốc!" }).ToList()
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