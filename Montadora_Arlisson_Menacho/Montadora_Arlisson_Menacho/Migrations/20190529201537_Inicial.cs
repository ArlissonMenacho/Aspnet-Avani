using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Montadora_Arlisson_Menacho.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Cidadeid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Cidadeid);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Usuarioid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Usuarioid);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cpf = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Orgaoexpedidor = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    ObjCidadeCidadeid = table.Column<int>(nullable: true),
                    Fornecedor_Endereco = table.Column<string>(nullable: true),
                    Salario = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Cidades_ObjCidadeCidadeid",
                        column: x => x.ObjCidadeCidadeid,
                        principalTable: "Cidades",
                        principalColumn: "Cidadeid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pecas",
                columns: table => new
                {
                    PecaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DtFabricacao = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    NumeroSerie = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    ObjFornecedorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pecas", x => x.PecaId);
                    table.ForeignKey(
                        name: "FK_Pecas_Pessoas_ObjFornecedorId",
                        column: x => x.ObjFornecedorId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Veiculoid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Categoria = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    ObjUsuarioUsuarioid = table.Column<int>(nullable: true),
                    ObjClienteId = table.Column<int>(nullable: true),
                    ObjMontadorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Veiculoid);
                    table.ForeignKey(
                        name: "FK_Veiculos_Pessoas_ObjClienteId",
                        column: x => x.ObjClienteId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculos_Pessoas_ObjMontadorId",
                        column: x => x.ObjMontadorId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculos_Usuarios_ObjUsuarioUsuarioid",
                        column: x => x.ObjUsuarioUsuarioid,
                        principalTable: "Usuarios",
                        principalColumn: "Usuarioid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PecaDosVeiculos",
                columns: table => new
                {
                    PecadoVeiculoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Desconto = table.Column<decimal>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    ObjPecaPecaId = table.Column<int>(nullable: true),
                    Veiculoid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PecaDosVeiculos", x => x.PecadoVeiculoId);
                    table.ForeignKey(
                        name: "FK_PecaDosVeiculos_Pecas_ObjPecaPecaId",
                        column: x => x.ObjPecaPecaId,
                        principalTable: "Pecas",
                        principalColumn: "PecaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PecaDosVeiculos_Veiculos_Veiculoid",
                        column: x => x.Veiculoid,
                        principalTable: "Veiculos",
                        principalColumn: "Veiculoid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PecaDosVeiculos_ObjPecaPecaId",
                table: "PecaDosVeiculos",
                column: "ObjPecaPecaId");

            migrationBuilder.CreateIndex(
                name: "IX_PecaDosVeiculos_Veiculoid",
                table: "PecaDosVeiculos",
                column: "Veiculoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pecas_ObjFornecedorId",
                table: "Pecas",
                column: "ObjFornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_ObjCidadeCidadeid",
                table: "Pessoas",
                column: "ObjCidadeCidadeid");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_ObjClienteId",
                table: "Veiculos",
                column: "ObjClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_ObjMontadorId",
                table: "Veiculos",
                column: "ObjMontadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_ObjUsuarioUsuarioid",
                table: "Veiculos",
                column: "ObjUsuarioUsuarioid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PecaDosVeiculos");

            migrationBuilder.DropTable(
                name: "Pecas");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Cidades");
        }
    }
}
