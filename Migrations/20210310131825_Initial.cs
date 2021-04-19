using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avtosolon.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbCategories",
                columns: table => new
                {
                    CategoryName = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CatDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dbInfoCar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    SortDesc = table.Column<string>(nullable: true),
                    LongDesc = table.Column<string>(nullable: true),
                    Favourite = table.Column<bool>(nullable: false),
                    Avaible = table.Column<bool>(nullable: false),
                    CatID = table.Column<int>(nullable: false),
                    CategoriesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbInfoCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbInfoCar_dbCategories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "dbCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbInfoCar_CategoriesId",
                table: "dbInfoCar",
                column: "CategoriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbInfoCar");

            migrationBuilder.DropTable(
                name: "dbCategories");
        }
    }
}
