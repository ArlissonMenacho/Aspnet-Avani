using Microsoft.EntityFrameworkCore.Migrations;

namespace LaboratorioArlissonMenacho.Migrations
{
    public partial class razaosocial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RazaoSocial",
                table: "Planos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RazaoSocial",
                table: "Planos");
        }
    }
}
