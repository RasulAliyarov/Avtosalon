using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avtosolon.Migrations
{
    public partial class Korzina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "danniyeKorzini",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarsId = table.Column<int>(nullable: true),
                    IdKorzini = table.Column<string>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danniyeKorzini", x => x.Id);
                    table.ForeignKey(
                        name: "FK_danniyeKorzini_dbInfoCar_CarsId",
                        column: x => x.CarsId,
                        principalTable: "dbInfoCar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_danniyeKorzini_CarsId",
                table: "danniyeKorzini",
                column: "CarsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "danniyeKorzini");
        }
    }
}
