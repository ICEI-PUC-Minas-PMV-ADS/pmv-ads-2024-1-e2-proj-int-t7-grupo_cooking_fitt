using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingFit_backend.Migrations
{
    public partial class M03AddTableCardapio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cardápio",
                table: "Cardápio");

            migrationBuilder.RenameTable(
                name: "Cardápio",
                newName: "Cardapio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cardapio",
                table: "Cardapio",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cardapio",
                table: "Cardapio");

            migrationBuilder.RenameTable(
                name: "Cardapio",
                newName: "Cardápio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cardápio",
                table: "Cardápio",
                column: "Id");
        }
    }
}
