using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoInterativa.Migrations
{
    public partial class AjustesMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Fabricante_fabricanteId",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Produto",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "fabricanteId",
                table: "Produto",
                newName: "FabricanteId");

            migrationBuilder.RenameColumn(
                name: "produtoId",
                table: "Produto",
                newName: "ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_fabricanteId",
                table: "Produto",
                newName: "IX_Produto_FabricanteId");

            migrationBuilder.AddColumn<string>(
                name: "CategoriaFabricante",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Fabricante_FabricanteId",
                table: "Produto",
                column: "FabricanteId",
                principalTable: "Fabricante",
                principalColumn: "FabricanteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Fabricante_FabricanteId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "CategoriaFabricante",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Produto",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "FabricanteId",
                table: "Produto",
                newName: "fabricanteId");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "Produto",
                newName: "produtoId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_FabricanteId",
                table: "Produto",
                newName: "IX_Produto_fabricanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Fabricante_fabricanteId",
                table: "Produto",
                column: "fabricanteId",
                principalTable: "Fabricante",
                principalColumn: "FabricanteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
