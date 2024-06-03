using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingFit_backend.Migrations
{
    public partial class AddFKTableIngrediente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoIngredienteId",
                table: "Ingrediente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ingrediente_TipoIngredienteId",
                table: "Ingrediente",
                column: "TipoIngredienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingrediente_TipoIngrediente_TipoIngredienteId",
                table: "Ingrediente",
                column: "TipoIngredienteId",
                principalTable: "TipoIngrediente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingrediente_TipoIngrediente_TipoIngredienteId",
                table: "Ingrediente");

            migrationBuilder.DropIndex(
                name: "IX_Ingrediente_TipoIngredienteId",
                table: "Ingrediente");

            migrationBuilder.DropColumn(
                name: "TipoIngredienteId",
                table: "Ingrediente");
        }
    }
}
