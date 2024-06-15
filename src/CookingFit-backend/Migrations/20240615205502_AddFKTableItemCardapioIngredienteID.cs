using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingFit_backend.Migrations
{
    public partial class AddFKTableItemCardapioIngredienteID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IngredienteId_IC",
                table: "ItemCardapio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ItemCardapio_IngredienteId_IC",
                table: "ItemCardapio",
                column: "IngredienteId_IC");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCardapio_Ingrediente_IngredienteId_IC",
                table: "ItemCardapio",
                column: "IngredienteId_IC",
                principalTable: "Ingrediente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemCardapio_Ingrediente_IngredienteId_IC",
                table: "ItemCardapio");

            migrationBuilder.DropIndex(
                name: "IX_ItemCardapio_IngredienteId_IC",
                table: "ItemCardapio");

            migrationBuilder.DropColumn(
                name: "IngredienteId_IC",
                table: "ItemCardapio");
        }
    }
}
