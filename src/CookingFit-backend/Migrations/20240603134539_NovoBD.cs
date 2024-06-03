using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingFit_backend.Migrations
{
    public partial class NovoBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Certifique-se de que a tabela Ingrediente existe e tem a chave primária
            migrationBuilder.CreateTable(
                name: "Ingrediente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    // Adicione outras colunas necessárias
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingrediente", x => x.Id);
                });

            // Criação da tabela Cardapio
            migrationBuilder.CreateTable(
                name: "Cardapio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    // Adicione outras colunas necessárias
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cardapio", x => x.Id);
                });

            // Criação da tabela de relacionamento
            migrationBuilder.CreateTable(
                name: "CardapioIngrediente",
                columns: table => new
                {
                    CardapioId = table.Column<int>(type: "int", nullable: false),
                    IngredientesAssociadosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardapioIngrediente", x => new { x.CardapioId, x.IngredientesAssociadosId });
                    table.ForeignKey(
                        name: "FK_CardapioIngrediente_Cardapio_CardapioId",
                        column: x => x.CardapioId,
                        principalTable: "Cardapio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardapioIngrediente_Ingrediente_IngredientesAssociadosId",
                        column: x => x.IngredientesAssociadosId,
                        principalTable: "Ingrediente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardapioIngrediente_IngredientesAssociadosId",
                table: "CardapioIngrediente",
                column: "IngredientesAssociadosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardapioIngrediente");

            migrationBuilder.DropTable(
                name: "Cardapio");

            migrationBuilder.DropTable(
                name: "Ingrediente");
        }

    }
}
