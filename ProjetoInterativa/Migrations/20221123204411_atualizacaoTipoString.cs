using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoInterativa.Migrations
{
    public partial class atualizacaoTipoString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Fabricante_FabricanteId",
                table: "Produto");

            migrationBuilder.AlterColumn<int>(
                name: "FabricanteId",
                table: "Produto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "FabricanteNome",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Fabricante_FabricanteId",
                table: "Produto",
                column: "FabricanteId",
                principalTable: "Fabricante",
                principalColumn: "FabricanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Fabricante_FabricanteId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "FabricanteNome",
                table: "Produto");

            migrationBuilder.AlterColumn<int>(
                name: "FabricanteId",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Fabricante_FabricanteId",
                table: "Produto",
                column: "FabricanteId",
                principalTable: "Fabricante",
                principalColumn: "FabricanteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
