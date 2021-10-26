using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QCService.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AQLLibrary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SeqNo = table.Column<int>(type: "int", nullable: false),
                    LotSize = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SampleSize = table.Column<int>(type: "int", nullable: false),
                    Accept = table.Column<int>(type: "int", nullable: false),
                    Reject = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AQLLibrary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DefectType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ReasonsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolutionsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandlersJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletionTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefectType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QCTicket",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ZoneTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TesterCheckId = table.Column<int>(type: "int", nullable: false),
                    ProductLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    DefectsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefectSizeBreakDownJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefectRepairsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivateDetailJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QCTicket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZoneType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    GroupType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Defect",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DefectsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolutionsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZoneTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Defect_ZoneType_ZoneTypeId",
                        column: x => x.ZoneTypeId,
                        principalTable: "ZoneType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AQLLibrary",
                columns: new[] { "Id", "Accept", "Category", "CreateDate", "CreateUserId", "Description", "LotSize", "Reject", "SampleSize", "SeqNo", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("9f6f0a5a-900e-44b0-9fb7-dbe1dd1aed66"), 1, "AQL 2.5", new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9043), 0, null, "51-90", 2, 13, 2, new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9051), 0 },
                    { new Guid("ac1c939d-2ef6-42c5-a953-d535af0a0475"), 1, "AQL 2.5", new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9061), 0, null, "91-150", 2, 20, 3, new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9063), 0 },
                    { new Guid("3f11283f-d11b-4266-b658-16e82b01d991"), 2, "AQL 2.5", new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9068), 0, null, "151-280", 3, 32, 4, new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9069), 0 },
                    { new Guid("02884a90-921e-44fe-a6f3-4d56bc660d98"), 3, "AQL 2.5", new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9072), 0, null, "281-500", 4, 50, 5, new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9073), 0 },
                    { new Guid("2bf9a034-9773-4763-b45a-62cb64b4fe60"), 5, "AQL 2.5", new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9076), 0, null, "501-1.200", 6, 80, 6, new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9077), 0 },
                    { new Guid("20307cd9-7775-437b-b56f-3decd98ba56e"), 7, "AQL 2.5", new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9080), 0, null, "1.201-3.200", 8, 125, 7, new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9081), 0 },
                    { new Guid("c0619a96-4bc9-4036-8699-7f29ba9f035c"), 10, "AQL 2.5", new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9084), 0, null, "3.201-10.000", 11, 200, 8, new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9085), 0 },
                    { new Guid("a008c1d5-bea1-4790-aa14-d37e300593f1"), 14, "AQL 2.5", new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9088), 0, null, "15.001-500.000", 15, 315, 9, new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9089), 0 },
                    { new Guid("81c393a2-6188-4012-8f42-85fd197f273b"), 21, "AQL 2.5", new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9092), 0, null, "500.000 over", 22, 500, 10, new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9093), 0 },
                    { new Guid("7680f05d-5794-454c-85b1-2291e4882828"), 1, "Sizeset-Pilot", new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9096), 0, null, "10", 2, 10, 1, new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9097), 0 },
                    { new Guid("4facb93b-a39d-4941-858b-6955b5e90eca"), 1, "Sizeset-Pilot", new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9100), 0, null, "20", 2, 20, 2, new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9101), 0 },
                    { new Guid("baf4f214-b6d4-4f59-ba03-c642d3806299"), 2, "Sizeset-Pilot", new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9103), 0, null, "30", 3, 30, 3, new DateTime(2021, 10, 22, 16, 57, 45, 347, DateTimeKind.Local).AddTicks(9104), 0 }
                });

            migrationBuilder.InsertData(
                table: "DefectType",
                columns: new[] { "Id", "Code", "CompletionTime", "CreateDate", "CreateUserId", "Description", "HandlersJson", "Name", "ReasonsJson", "SolutionsJson", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("9c1d76c0-4e0a-4dae-b2ec-c06a906442b6"), "S01", null, new DateTime(2021, 10, 22, 16, 57, 45, 363, DateTimeKind.Local).AddTicks(7830), 0, null, "[\"Proplem6 reason1 soluiton1 Handler1\",\"Proplem6 reason2 soluiton2 Handler2\",\"Proplem6 reason3 soluiton3 Handler3\",\"Proplem6 reason4 soluiton4 Handler4\",\"Proplem6 reason5 soluiton5 Handler5\"]", "Proplem6", "[\"Proplem6 reason1\",\"Proplem6 reason2\",\"Proplem6 reason3\",\"Proplem6 reason4\",\"Proplem6 reason5\"]", "[\"Proplem6 reason1 solution1\",\"Proplem6 reason2 solution2\",\"Proplem6 reason3 solution3\",\"Proplem6 reason4 solution4\",\"Proplem6 reason5 solution5\"]", new DateTime(2021, 10, 22, 16, 57, 45, 363, DateTimeKind.Local).AddTicks(7837), 0 },
                    { new Guid("b8f567f2-c62b-431e-acc8-79ca56dc9aa8"), "S01", null, new DateTime(2021, 10, 22, 16, 57, 45, 363, DateTimeKind.Local).AddTicks(6148), 0, null, "[\"Proplem5 reason1 soluiton1 Handler1\",\"Proplem5 reason2 soluiton2 Handler2\",\"Proplem5 reason3 soluiton3 Handler3\",\"Proplem5 reason4 soluiton4 Handler4\",\"Proplem5 reason5 soluiton5 Handler5\"]", "Proplem5", "[\"Proplem5 reason1\",\"Proplem5 reason2\",\"Proplem5 reason3\",\"Proplem5 reason4\",\"Proplem5 reason5\"]", "[\"Proplem5 reason1 solution1\",\"Proplem5 reason2 solution2\",\"Proplem5 reason3 solution3\",\"Proplem5 reason4 solution4\",\"Proplem5 reason5 solution5\"]", new DateTime(2021, 10, 22, 16, 57, 45, 363, DateTimeKind.Local).AddTicks(6154), 0 },
                    { new Guid("e1bedd68-8c62-4320-bcd3-a2692398e0e8"), "S01", null, new DateTime(2021, 10, 22, 16, 57, 45, 363, DateTimeKind.Local).AddTicks(4380), 0, null, "[\"Proplem4 reason1 soluiton1 Handler1\",\"Proplem4 reason2 soluiton2 Handler2\",\"Proplem4 reason3 soluiton3 Handler3\",\"Proplem4 reason4 soluiton4 Handler4\",\"Proplem4 reason5 soluiton5 Handler5\"]", "Proplem4", "[\"Proplem4 reason1\",\"Proplem4 reason2\",\"Proplem4 reason3\",\"Proplem4 reason4\",\"Proplem4 reason5\"]", "[\"Proplem4 reason1 solution1\",\"Proplem4 reason2 solution2\",\"Proplem4 reason3 solution3\",\"Proplem4 reason4 solution4\",\"Proplem4 reason5 solution5\"]", new DateTime(2021, 10, 22, 16, 57, 45, 363, DateTimeKind.Local).AddTicks(4388), 0 },
                    { new Guid("0063529e-81d9-4d53-bd4a-1fd21496dc97"), "S01", null, new DateTime(2021, 10, 22, 16, 57, 45, 363, DateTimeKind.Local).AddTicks(1420), 0, null, "[\"Proplem3 reason1 soluiton1 Handler1\",\"Proplem3 reason2 soluiton2 Handler2\",\"Proplem3 reason3 soluiton3 Handler3\",\"Proplem3 reason4 soluiton4 Handler4\",\"Proplem3 reason5 soluiton5 Handler5\"]", "Proplem3", "[\"Proplem3 reason1\",\"Proplem3 reason2\",\"Proplem3 reason3\",\"Proplem3 reason4\",\"Proplem3 reason5\"]", "[\"Proplem3 reason1 solution1\",\"Proplem3 reason2 solution2\",\"Proplem3 reason3 solution3\",\"Proplem3 reason4 solution4\",\"Proplem3 reason5 solution5\"]", new DateTime(2021, 10, 22, 16, 57, 45, 363, DateTimeKind.Local).AddTicks(1425), 0 },
                    { new Guid("7da1e425-7ebb-40ef-a868-7a3ba7e38214"), "S01", null, new DateTime(2021, 10, 22, 16, 57, 45, 362, DateTimeKind.Local).AddTicks(9858), 0, null, "[\"Proplem2 reason1 soluiton1 Handler1\",\"Proplem2 reason2 soluiton2 Handler2\",\"Proplem2 reason3 soluiton3 Handler3\",\"Proplem2 reason4 soluiton4 Handler4\",\"Proplem2 reason5 soluiton5 Handler5\"]", "Proplem2", "[\"Proplem2 reason1\",\"Proplem2 reason2\",\"Proplem2 reason3\",\"Proplem2 reason4\",\"Proplem2 reason5\"]", "[\"Proplem2 reason1 solution1\",\"Proplem2 reason2 solution2\",\"Proplem2 reason3 solution3\",\"Proplem2 reason4 solution4\",\"Proplem2 reason5 solution5\"]", new DateTime(2021, 10, 22, 16, 57, 45, 362, DateTimeKind.Local).AddTicks(9865), 0 },
                    { new Guid("92e46adb-51cb-41d5-9252-f572e309399e"), "S01", null, new DateTime(2021, 10, 22, 16, 57, 45, 362, DateTimeKind.Local).AddTicks(8077), 0, null, "[\"Proplem1 reason1 soluiton1 Handler1\",\"Proplem1 reason2 soluiton2 Handler2\",\"Proplem1 reason3 soluiton3 Handler3\",\"Proplem1 reason4 soluiton4 Handler4\",\"Proplem1 reason5 soluiton5 Handler5\"]", "Proplem1", "[\"Proplem1 reason1\",\"Proplem1 reason2\",\"Proplem1 reason3\",\"Proplem1 reason4\",\"Proplem1 reason5\"]", "[\"Proplem1 reason1 solution1\",\"Proplem1 reason2 solution2\",\"Proplem1 reason3 solution3\",\"Proplem1 reason4 solution4\",\"Proplem1 reason5 solution5\"]", new DateTime(2021, 10, 22, 16, 57, 45, 362, DateTimeKind.Local).AddTicks(8103), 0 }
                });

            migrationBuilder.InsertData(
                table: "ZoneType",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "Description", "GroupType", "Name", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3"), "Fabric Storage Has Roll", new DateTime(2021, 10, 22, 16, 57, 45, 343, DateTimeKind.Local).AddTicks(2106), 0, "kho vải có roll", 1, "Fabric Storage Has Roll", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(6993), 0 },
                    { new Guid("63892f60-c8cb-40de-b365-e52f66a04ec4"), "Fabric Storage Has no Roll", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7345), 0, "kho vải không roll", 2, "Fabric Storage Has no Roll", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7351), 0 },
                    { new Guid("f34e7928-c4f0-4f84-95f7-335d73196358"), "Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7356), 0, "kho nguyên phụ liệu", 2, "Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7357), 0 },
                    { new Guid("5ea2209a-9782-4cda-a4ba-71a4f5a53964"), "Cut Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7360), 0, "công đoạn cắt (CUT)", 3, "Cut Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7361), 0 },
                    { new Guid("93492f52-c22d-4224-8770-fcf410062e6a"), "Print Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7364), 0, "công đoạn in (PRINT)", 3, "Print Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7365), 0 },
                    { new Guid("de72a6a9-bd09-48e3-b48e-19494d3ddb43"), "Emboidery Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7426), 0, "công đoạn thuê (EMBOIDERY)", 3, "Emboidery Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7427), 0 },
                    { new Guid("ca691bec-ae50-4884-9e5e-7e6f84b24087"), "Sew Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7430), 0, "công đoạn may (SEW)", 3, "Sew Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7431), 0 },
                    { new Guid("cd6aac51-979f-499b-a9bc-55681caf2956"), "Finish Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7434), 0, "công đoạn wash (SEND TO FINISH)", 3, "Finish Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7435), 0 },
                    { new Guid("3fe931f7-728b-48e6-b37c-828f683f9229"), "Packing Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7437), 0, "công đoạn hoàn tất (PACKING)", 3, "Packing Operation", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7438), 0 },
                    { new Guid("c414c4a2-eca1-4cc3-b598-99d7f1c5b1ec"), "Pre-Final", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7441), 0, "Pre-Final", 4, "Pre-Final", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7442), 0 },
                    { new Guid("7ced9b1f-31ad-4452-a625-81f48afe0e24"), "Final", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7445), 0, "Final", 4, "Final", new DateTime(2021, 10, 22, 16, 57, 45, 346, DateTimeKind.Local).AddTicks(7446), 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Defect_Code_Name",
                table: "Defect",
                columns: new[] { "Code", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_Defect_ZoneTypeId",
                table: "Defect",
                column: "ZoneTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DefectType_Code_Name",
                table: "DefectType",
                columns: new[] { "Code", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_QCTicket_Code_Name",
                table: "QCTicket",
                columns: new[] { "Code", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_ZoneType_Code_Name",
                table: "ZoneType",
                columns: new[] { "Code", "Name" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AQLLibrary");

            migrationBuilder.DropTable(
                name: "Defect");

            migrationBuilder.DropTable(
                name: "DefectType");

            migrationBuilder.DropTable(
                name: "QCTicket");

            migrationBuilder.DropTable(
                name: "ZoneType");
        }
    }
}
