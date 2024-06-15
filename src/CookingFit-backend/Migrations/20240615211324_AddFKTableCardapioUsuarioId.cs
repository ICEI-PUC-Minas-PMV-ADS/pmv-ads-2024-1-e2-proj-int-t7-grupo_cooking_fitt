using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingFit_backend.Migrations
{
    public partial class AddFKTableCardapioUsuarioId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId_Cardapio",
                table: "Cardapio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cardapio_UsuarioId_Cardapio",
                table: "Cardapio",
                column: "UsuarioId_Cardapio");

            migrationBuilder.AddForeignKey(
                name: "FK_Cardapio_Usuario_UsuarioId_Cardapio",
                table: "Cardapio",
                column: "UsuarioId_Cardapio",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cardapio_Usuario_UsuarioId_Cardapio",
                table: "Cardapio");

            migrationBuilder.DropIndex(
                name: "IX_Cardapio_UsuarioId_Cardapio",
                table: "Cardapio");

            migrationBuilder.DropColumn(
                name: "UsuarioId_Cardapio",
                table: "Cardapio");
        }
    }
}
