using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryService.Migrations
{
    public partial class initAndSeedFakeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZoneType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AQLLibrary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ZoneTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AQLLibrary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AQLLibrary_ZoneType_ZoneTypeId",
                        column: x => x.ZoneTypeId,
                        principalTable: "ZoneType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Defective",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ZoneTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defective", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Defective_ZoneType_ZoneTypeId",
                        column: x => x.ZoneTypeId,
                        principalTable: "ZoneType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolutionDefective",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ZoneTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolutionDefective", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolutionDefective_ZoneType_ZoneTypeId",
                        column: x => x.ZoneTypeId,
                        principalTable: "ZoneType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ZoneType",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("329c4ebe-dc09-4fbe-92d4-4770550903e3"), "ZoneType Description 1", "ZoneType Name 1" },
                    { new Guid("d2bcd226-430d-42e2-b167-24b42acef75d"), "ZoneType Description 2", "ZoneType Name 2" },
                    { new Guid("27410b30-d180-4085-9ae2-c327f56e8fc1"), "ZoneType Description 3", "ZoneType Name 3" },
                    { new Guid("21859bd9-27d0-4321-bcf2-7ac5cb36be07"), "ZoneType Description 4", "ZoneType Name 4" },
                    { new Guid("fbd628eb-6711-4f01-959b-a581473a2523"), "ZoneType Description 5", "ZoneType Name 5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AQLLibrary_ZoneTypeId",
                table: "AQLLibrary",
                column: "ZoneTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Defective_ZoneTypeId",
                table: "Defective",
                column: "ZoneTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SolutionDefective_ZoneTypeId",
                table: "SolutionDefective",
                column: "ZoneTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AQLLibrary");

            migrationBuilder.DropTable(
                name: "Defective");

            migrationBuilder.DropTable(
                name: "SolutionDefective");

            migrationBuilder.DropTable(
                name: "ZoneType");
        }
    }
}
