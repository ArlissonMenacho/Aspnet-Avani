using Microsoft.EntityFrameworkCore.Migrations;

namespace Montadora_Arlisson_Menacho.Migrations
{
    public partial class cidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Cidades_ObjCidadeCidadeid",
                table: "Pessoas");

            migrationBuilder.RenameColumn(
                name: "ObjCidadeCidadeid",
                table: "Pessoas",
                newName: "ObjCidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoas_ObjCidadeCidadeid",
                table: "Pessoas",
                newName: "IX_Pessoas_ObjCidadeId");

            migrationBuilder.RenameColumn(
                name: "Cidadeid",
                table: "Cidades",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Categoria",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cidades",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Cidades_ObjCidadeId",
                table: "Pessoas",
                column: "ObjCidadeId",
                principalTable: "Cidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Cidades_ObjCidadeId",
                table: "Pessoas");

            migrationBuilder.RenameColumn(
                name: "ObjCidadeId",
                table: "Pessoas",
                newName: "ObjCidadeCidadeid");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoas_ObjCidadeId",
                table: "Pessoas",
                newName: "IX_Pessoas_ObjCidadeCidadeid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cidades",
                newName: "Cidadeid");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Categoria",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cidades",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Cidades_ObjCidadeCidadeid",
                table: "Pessoas",
                column: "ObjCidadeCidadeid",
                principalTable: "Cidades",
                principalColumn: "Cidadeid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
