using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoFinal.Migrations
{
    public partial class Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CompradorCpf",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "LojaCnpj",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Comprador",
                columns: table => new
                {
                    Cpf = table.Column<double>(nullable: false),
                    Primeiro_nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Telefone = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comprador", x => x.Cpf);
                });

            migrationBuilder.CreateTable(
                name: "Loja",
                columns: table => new
                {
                    Cnpj = table.Column<double>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Num_Vendas = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loja", x => x.Cnpj);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CompradorCpf",
                table: "Usuario",
                column: "CompradorCpf");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_LojaCnpj",
                table: "Usuario",
                column: "LojaCnpj");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Comprador_CompradorCpf",
                table: "Usuario",
                column: "CompradorCpf",
                principalTable: "Comprador",
                principalColumn: "Cpf",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Loja_LojaCnpj",
                table: "Usuario",
                column: "LojaCnpj",
                principalTable: "Loja",
                principalColumn: "Cnpj",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Comprador_CompradorCpf",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Loja_LojaCnpj",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "Comprador");

            migrationBuilder.DropTable(
                name: "Loja");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_CompradorCpf",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_LojaCnpj",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "CompradorCpf",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "LojaCnpj",
                table: "Usuario");
        }
    }
}
