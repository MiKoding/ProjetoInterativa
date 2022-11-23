using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoInterativa.Migrations
{
    public partial class IncluirTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fabricante",
                columns: table => new
                {
                    FabricanteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FabricanteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categoria2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categoria3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricante", x => x.FabricanteId);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    produtoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    fabricanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.produtoId);
                    table.ForeignKey(
                        name: "FK_Produto_Fabricante_fabricanteId",
                        column: x => x.fabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "FabricanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_fabricanteId",
                table: "Produto",
                column: "fabricanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Fabricante");
        }
    }
}
