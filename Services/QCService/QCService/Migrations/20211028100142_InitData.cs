using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QCService.Migrations
{
    public partial class InitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "C01_QCZoneTypeLib",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GroupType = table.Column<int>(type: "int", nullable: false),
                    FormsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C01_QCZoneTypeLib", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "C01_AQLLib",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SeqNo = table.Column<int>(type: "int", nullable: false),
                    LotSize = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ZoneTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C01_AQLLib", x => x.Id);
                    table.ForeignKey(
                        name: "FK_C01_AQLLib_C01_QCZoneTypeLib_ZoneTypeId",
                        column: x => x.ZoneTypeId,
                        principalTable: "C01_QCZoneTypeLib",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "C01_DefectLib",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ReasonsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolutionsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandlersJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZoneTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C01_DefectLib", x => x.Id);
                    table.ForeignKey(
                        name: "FK_C01_DefectLib_C01_QCZoneTypeLib_ZoneTypeId",
                        column: x => x.ZoneTypeId,
                        principalTable: "C01_QCZoneTypeLib",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "C02_QCRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZoneTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QCNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    GRNNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Category = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ArticleCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ArticleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QCRequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StyleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StyleCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OCNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QCDefinition = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SamplePlan = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SamplePercentage = table.Column<int>(type: "int", nullable: false),
                    ColorCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ColorName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    QCType = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SizeBreakDownsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserApproveId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C02_QCRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_C02_QCRequest_C01_QCZoneTypeLib_ZoneTypeId",
                        column: x => x.ZoneTypeId,
                        principalTable: "C01_QCZoneTypeLib",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "C02_QCTicket",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProductLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefectAQLJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefectSizeBreakDownJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefectsReasonAndSolutionsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivateDetailJson = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C02_QCTicket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_C02_QCTicket_C02_QCRequest_Id",
                        column: x => x.Id,
                        principalTable: "C02_QCRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "C01_AQLLib",
                columns: new[] { "Id", "Category", "CreateDate", "CreateUserId", "Description", "LotSize", "SeqNo", "UpdateDate", "UpdateUserId", "ZoneTypeId" },
                values: new object[,]
                {
                    { new Guid("9f6f0a5a-900e-44b0-9fb7-dbe1dd1aed66"), "AQL 2.5", new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1219), 0, null, "51-90", 2, new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1228), 0, null },
                    { new Guid("ac1c939d-2ef6-42c5-a953-d535af0a0475"), "AQL 2.5", new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1237), 0, null, "91-150", 3, new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1238), 0, null },
                    { new Guid("3f11283f-d11b-4266-b658-16e82b01d991"), "AQL 2.5", new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1241), 0, null, "151-280", 4, new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1242), 0, null },
                    { new Guid("02884a90-921e-44fe-a6f3-4d56bc660d98"), "AQL 2.5", new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1246), 0, null, "281-500", 5, new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1247), 0, null },
                    { new Guid("2bf9a034-9773-4763-b45a-62cb64b4fe60"), "AQL 2.5", new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1251), 0, null, "501-1.200", 6, new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1252), 0, null },
                    { new Guid("20307cd9-7775-437b-b56f-3decd98ba56e"), "AQL 2.5", new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1255), 0, null, "1.201-3.200", 7, new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1256), 0, null },
                    { new Guid("c0619a96-4bc9-4036-8699-7f29ba9f035c"), "AQL 2.5", new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1259), 0, null, "3.201-10.000", 8, new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1260), 0, null },
                    { new Guid("a008c1d5-bea1-4790-aa14-d37e300593f1"), "AQL 2.5", new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1262), 0, null, "15.001-500.000", 9, new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1263), 0, null },
                    { new Guid("81c393a2-6188-4012-8f42-85fd197f273b"), "AQL 2.5", new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1266), 0, null, "500.000 over", 10, new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1267), 0, null },
                    { new Guid("7680f05d-5794-454c-85b1-2291e4882828"), "Sizeset-Pilot", new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1270), 0, null, "10", 1, new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1271), 0, null },
                    { new Guid("4facb93b-a39d-4941-858b-6955b5e90eca"), "Sizeset-Pilot", new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1274), 0, null, "20", 2, new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1275), 0, null },
                    { new Guid("baf4f214-b6d4-4f59-ba03-c642d3806299"), "Sizeset-Pilot", new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1278), 0, null, "30", 3, new DateTime(2021, 10, 28, 17, 1, 42, 239, DateTimeKind.Local).AddTicks(1279), 0, null }
                });

            migrationBuilder.InsertData(
                table: "C01_DefectLib",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "Description", "HandlersJson", "Name", "ReasonsJson", "SolutionsJson", "UpdateDate", "UpdateUserId", "ZoneTypeId" },
                values: new object[,]
                {
                    { new Guid("9c1d76c0-4e0a-4dae-b2ec-c06a906442b6"), "S01", new DateTime(2021, 10, 28, 17, 1, 42, 253, DateTimeKind.Local).AddTicks(6396), 0, null, "[\"Proplem6 reason1 soluiton1 Handler1\",\"Proplem6 reason2 soluiton2 Handler2\",\"Proplem6 reason3 soluiton3 Handler3\",\"Proplem6 reason4 soluiton4 Handler4\",\"Proplem6 reason5 soluiton5 Handler5\"]", "Proplem6", "[\"Proplem6 reason1\",\"Proplem6 reason2\",\"Proplem6 reason3\",\"Proplem6 reason4\",\"Proplem6 reason5\"]", "[\"Proplem6 reason1 solution1\",\"Proplem6 reason2 solution2\",\"Proplem6 reason3 solution3\",\"Proplem6 reason4 solution4\",\"Proplem6 reason5 solution5\"]", new DateTime(2021, 10, 28, 17, 1, 42, 253, DateTimeKind.Local).AddTicks(6401), 0, null },
                    { new Guid("b8f567f2-c62b-431e-acc8-79ca56dc9aa8"), "S01", new DateTime(2021, 10, 28, 17, 1, 42, 253, DateTimeKind.Local).AddTicks(4889), 0, null, "[\"Proplem5 reason1 soluiton1 Handler1\",\"Proplem5 reason2 soluiton2 Handler2\",\"Proplem5 reason3 soluiton3 Handler3\",\"Proplem5 reason4 soluiton4 Handler4\",\"Proplem5 reason5 soluiton5 Handler5\"]", "Proplem5", "[\"Proplem5 reason1\",\"Proplem5 reason2\",\"Proplem5 reason3\",\"Proplem5 reason4\",\"Proplem5 reason5\"]", "[\"Proplem5 reason1 solution1\",\"Proplem5 reason2 solution2\",\"Proplem5 reason3 solution3\",\"Proplem5 reason4 solution4\",\"Proplem5 reason5 solution5\"]", new DateTime(2021, 10, 28, 17, 1, 42, 253, DateTimeKind.Local).AddTicks(4894), 0, null },
                    { new Guid("e1bedd68-8c62-4320-bcd3-a2692398e0e8"), "S01", new DateTime(2021, 10, 28, 17, 1, 42, 253, DateTimeKind.Local).AddTicks(3507), 0, null, "[\"Proplem4 reason1 soluiton1 Handler1\",\"Proplem4 reason2 soluiton2 Handler2\",\"Proplem4 reason3 soluiton3 Handler3\",\"Proplem4 reason4 soluiton4 Handler4\",\"Proplem4 reason5 soluiton5 Handler5\"]", "Proplem4", "[\"Proplem4 reason1\",\"Proplem4 reason2\",\"Proplem4 reason3\",\"Proplem4 reason4\",\"Proplem4 reason5\"]", "[\"Proplem4 reason1 solution1\",\"Proplem4 reason2 solution2\",\"Proplem4 reason3 solution3\",\"Proplem4 reason4 solution4\",\"Proplem4 reason5 solution5\"]", new DateTime(2021, 10, 28, 17, 1, 42, 253, DateTimeKind.Local).AddTicks(3511), 0, null },
                    { new Guid("0063529e-81d9-4d53-bd4a-1fd21496dc97"), "S01", new DateTime(2021, 10, 28, 17, 1, 42, 253, DateTimeKind.Local).AddTicks(2099), 0, null, "[\"Proplem3 reason1 soluiton1 Handler1\",\"Proplem3 reason2 soluiton2 Handler2\",\"Proplem3 reason3 soluiton3 Handler3\",\"Proplem3 reason4 soluiton4 Handler4\",\"Proplem3 reason5 soluiton5 Handler5\"]", "Proplem3", "[\"Proplem3 reason1\",\"Proplem3 reason2\",\"Proplem3 reason3\",\"Proplem3 reason4\",\"Proplem3 reason5\"]", "[\"Proplem3 reason1 solution1\",\"Proplem3 reason2 solution2\",\"Proplem3 reason3 solution3\",\"Proplem3 reason4 solution4\",\"Proplem3 reason5 solution5\"]", new DateTime(2021, 10, 28, 17, 1, 42, 253, DateTimeKind.Local).AddTicks(2103), 0, null },
                    { new Guid("7da1e425-7ebb-40ef-a868-7a3ba7e38214"), "S01", new DateTime(2021, 10, 28, 17, 1, 42, 253, DateTimeKind.Local).AddTicks(681), 0, null, "[\"Proplem2 reason1 soluiton1 Handler1\",\"Proplem2 reason2 soluiton2 Handler2\",\"Proplem2 reason3 soluiton3 Handler3\",\"Proplem2 reason4 soluiton4 Handler4\",\"Proplem2 reason5 soluiton5 Handler5\"]", "Proplem2", "[\"Proplem2 reason1\",\"Proplem2 reason2\",\"Proplem2 reason3\",\"Proplem2 reason4\",\"Proplem2 reason5\"]", "[\"Proplem2 reason1 solution1\",\"Proplem2 reason2 solution2\",\"Proplem2 reason3 solution3\",\"Proplem2 reason4 solution4\",\"Proplem2 reason5 solution5\"]", new DateTime(2021, 10, 28, 17, 1, 42, 253, DateTimeKind.Local).AddTicks(687), 0, null },
                    { new Guid("92e46adb-51cb-41d5-9252-f572e309399e"), "S01", new DateTime(2021, 10, 28, 17, 1, 42, 252, DateTimeKind.Local).AddTicks(9060), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", "Proplem1", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 10, 28, 17, 1, 42, 252, DateTimeKind.Local).AddTicks(9092), 0, null }
                });

            migrationBuilder.InsertData(
                table: "C01_QCZoneTypeLib",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "Description", "FormsJson", "GroupType", "Name", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), "Fabric Storage Has Roll", new DateTime(2021, 10, 28, 17, 1, 42, 236, DateTimeKind.Local).AddTicks(9230), 0, "kho vải có roll", null, 1, "Fabric Storage Has Roll", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(3), 0 },
                    { new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4"), "Fabric Storage Has no Roll", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(344), 0, "kho vải không roll", null, 2, "Fabric Storage Has no Roll", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(349), 0 },
                    { new Guid("f34e7928-c4f0-4f84-95f7-335d73196358"), "Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(354), 0, "kho nguyên phụ liệu", null, 2, "Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(355), 0 },
                    { new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), "Cut Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(359), 0, "công đoạn cắt (CUT)", null, 3, "Cut Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(360), 0 },
                    { new Guid("93492f52-c22d-4224-8770-fcf410062e6a"), "Print Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(363), 0, "công đoạn in (PRINT)", null, 3, "Print Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(364), 0 },
                    { new Guid("de72a6a9-bd09-48e3-b48e-19494d3ddb43"), "Emboidery Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(367), 0, "công đoạn thuê (EMBOIDERY)", null, 3, "Emboidery Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(368), 0 },
                    { new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087"), "Sew Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(371), 0, "công đoạn may (SEW)", null, 3, "Sew Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(372), 0 },
                    { new Guid("cd6aac51-979f-499b-a9bc-55681caf2956"), "Finish Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(378), 0, "công đoạn wash (SEND TO FINISH)", null, 3, "Finish Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(379), 0 },
                    { new Guid("3fe931f7-728b-48e6-b37c-828f683f9229"), "Packing Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(381), 0, "công đoạn hoàn tất (PACKING)", null, 3, "Packing Operation", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(383), 0 },
                    { new Guid("c414c4a2-eca1-4cc3-b598-99d7f1c5b1ec"), "Pre-Final", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(385), 0, "Pre-Final", null, 4, "Pre-Final", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(386), 0 },
                    { new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24"), "Final", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(389), 0, "Final", null, 4, "Final", new DateTime(2021, 10, 28, 17, 1, 42, 238, DateTimeKind.Local).AddTicks(390), 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_C01_AQLLib_ZoneTypeId",
                table: "C01_AQLLib",
                column: "ZoneTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_C01_DefectLib_Code_Name",
                table: "C01_DefectLib",
                columns: new[] { "Code", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_C01_DefectLib_ZoneTypeId",
                table: "C01_DefectLib",
                column: "ZoneTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_C01_QCZoneTypeLib_Code_Name",
                table: "C01_QCZoneTypeLib",
                columns: new[] { "Code", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_C02_QCRequest_ZoneTypeId_QCNumber_QCType",
                table: "C02_QCRequest",
                columns: new[] { "ZoneTypeId", "QCNumber", "QCType" });

            migrationBuilder.CreateIndex(
                name: "IX_C02_QCTicket_Code_Name",
                table: "C02_QCTicket",
                columns: new[] { "Code", "Name" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "C01_AQLLib");

            migrationBuilder.DropTable(
                name: "C01_DefectLib");

            migrationBuilder.DropTable(
                name: "C02_QCTicket");

            migrationBuilder.DropTable(
                name: "C02_QCRequest");

            migrationBuilder.DropTable(
                name: "C01_QCZoneTypeLib");
        }
    }
}
