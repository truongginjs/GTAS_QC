using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QCService.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "L01_HandlerDefectLib",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L01_HandlerDefectLib", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "L01_QCZoneTypeLib",
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
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L01_QCZoneTypeLib", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "L01_TimeDefectLib",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L01_TimeDefectLib", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D01_QCRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZoneTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransferStatus = table.Column<int>(type: "int", nullable: false),
                    DocStatus = table.Column<int>(type: "int", nullable: false),
                    Site = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Buyer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Supplier = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QCNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRNNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PONo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OCNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Category = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ArticleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QCRequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StyleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QCDefinition = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SamplePlan = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QCQty = table.Column<int>(type: "int", nullable: false),
                    DeliveryBuyerOrderRef = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ArticleCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StyleCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SamplePercentage = table.Column<double>(type: "float", nullable: false),
                    ColorCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ColorName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    QCType = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SizeBreakDownsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserApproveId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D01_QCRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D01_QCRequest_L01_QCZoneTypeLib_ZoneTypeId",
                        column: x => x.ZoneTypeId,
                        principalTable: "L01_QCZoneTypeLib",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "L01_AQLLib",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RatingMajor = table.Column<int>(type: "int", nullable: false),
                    RatingMinor = table.Column<int>(type: "int", nullable: false),
                    ZoneTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QCRagesJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L01_AQLLib", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L01_AQLLib_L01_QCZoneTypeLib_ZoneTypeId",
                        column: x => x.ZoneTypeId,
                        principalTable: "L01_QCZoneTypeLib",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "L01_DefectLib",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ReasonsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolutionsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefectTypeJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZoneTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L01_DefectLib", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L01_DefectLib_L01_QCZoneTypeLib_ZoneTypeId",
                        column: x => x.ZoneTypeId,
                        principalTable: "L01_QCZoneTypeLib",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "D01_QCDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProductLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InspectionBySizesJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefectDetailJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivateDetailJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D01_QCDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D01_QCDetail_D01_QCRequest_Id",
                        column: x => x.Id,
                        principalTable: "D01_QCRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_D01_QCDetail_Code_Name",
                table: "D01_QCDetail",
                columns: new[] { "Code", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_D01_QCRequest_ZoneTypeId_QCNumber_QCType",
                table: "D01_QCRequest",
                columns: new[] { "ZoneTypeId", "QCNumber", "QCType" });

            migrationBuilder.CreateIndex(
                name: "IX_L01_AQLLib_ZoneTypeId",
                table: "L01_AQLLib",
                column: "ZoneTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_L01_DefectLib_Code_Name",
                table: "L01_DefectLib",
                columns: new[] { "Code", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_L01_DefectLib_ZoneTypeId",
                table: "L01_DefectLib",
                column: "ZoneTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_L01_QCZoneTypeLib_Code_Name",
                table: "L01_QCZoneTypeLib",
                columns: new[] { "Code", "Name" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D01_QCDetail");

            migrationBuilder.DropTable(
                name: "L01_AQLLib");

            migrationBuilder.DropTable(
                name: "L01_DefectLib");

            migrationBuilder.DropTable(
                name: "L01_HandlerDefectLib");

            migrationBuilder.DropTable(
                name: "L01_TimeDefectLib");

            migrationBuilder.DropTable(
                name: "D01_QCRequest");

            migrationBuilder.DropTable(
                name: "L01_QCZoneTypeLib");
        }
    }
}
