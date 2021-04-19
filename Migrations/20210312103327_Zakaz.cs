using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avtosolon.Migrations
{
    public partial class Zakaz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbZakaza",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbZakaza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dbElementiZakaza",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarId = table.Column<int>(nullable: false),
                    IdZakaza = table.Column<int>(nullable: false),
                    GetInfoId = table.Column<int>(nullable: true),
                    GetZakazId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbElementiZakaza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbElementiZakaza_dbInfoCar_GetInfoId",
                        column: x => x.GetInfoId,
                        principalTable: "dbInfoCar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbElementiZakaza_dbZakaza_GetZakazId",
                        column: x => x.GetZakazId,
                        principalTable: "dbZakaza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbElementiZakaza_GetInfoId",
                table: "dbElementiZakaza",
                column: "GetInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_dbElementiZakaza_GetZakazId",
                table: "dbElementiZakaza",
                column: "GetZakazId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbElementiZakaza");

            migrationBuilder.DropTable(
                name: "dbZakaza");
        }
    }
}
