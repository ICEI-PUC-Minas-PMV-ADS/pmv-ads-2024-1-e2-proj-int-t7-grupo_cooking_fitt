using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingFit_backend.Migrations
{
    public partial class AddTableNewItemCardapio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemCardapio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaloriasItem = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    TipoCardapioId = table.Column<int>(type: "int", nullable: false),
                    TipoIngredienteIdItem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCardapio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCardapio_TipoIngrediente_TipoIngredienteIdItem",
                        column: x => x.TipoIngredienteIdItem,
                        principalTable: "TipoIngrediente",
                        principalColumn: "Id");

                    table.ForeignKey(
                    name: "FK_ItemCardapio_TipoCardapio_TipoCardapioId",
                    column: x => x.TipoCardapioId,
                    principalTable: "TipoCardapio",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                });


            migrationBuilder.CreateIndex(
                name: "IX_ItemCardapio_TipoIngredienteIdItem",
                table: "ItemCardapio",
                column: "TipoIngredienteIdItem");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCardapio_TipoCardapioId",
                table: "ItemCardapio",
                column: "TipoCardapioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemCardapio");
        }
    }
}
