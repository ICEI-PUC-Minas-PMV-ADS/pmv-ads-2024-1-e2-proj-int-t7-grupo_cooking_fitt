using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingFit_backend.Migrations
{
    public partial class AddFkIngredientetoCardapio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IngredienteId",
                table: "Cardapio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ingrediente_IngredienteId",
                table: "Cardapio",
                column: "IngredienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cardapio_Ingrediente_IngredienteId",
                table: "Cardapio",
                column: "IngredienteId",
                principalTable: "Ingrediente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cardapio_Ingrediente_IngredienteId",
                table: "Cardapio");

            migrationBuilder.DropIndex(
                name: "IX_Cardapio_IngredienteId",
                table: "Cardapio");

            migrationBuilder.DropColumn(
                name: "IngredienteId",
                table: "Cardapio");
        }
    }
}
