using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingFit_backend.Migrations
{
    public partial class TipoAlimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "TipoIngrediente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoIngrediente", x => x.Id);
                });
        }

    }
}
