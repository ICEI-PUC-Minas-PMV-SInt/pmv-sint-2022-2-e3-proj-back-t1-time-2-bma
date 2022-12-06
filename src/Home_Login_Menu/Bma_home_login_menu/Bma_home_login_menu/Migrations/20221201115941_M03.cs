using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bmahomeloginmenu.Migrations
{
    /// <inheritdoc />
    public partial class M03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beneficiario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(name: "Data_Nascimento", type: "datetime2", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cestabasica = table.Column<bool>(name: "Cesta_basica", type: "bit", nullable: false),
                    CestaVerde = table.Column<bool>(name: "Cesta_Verde", type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dependentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(name: "Data_Nascimento", type: "datetime2", nullable: false),
                    BeneficiarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dependentes_Beneficiario_BeneficiarioId",
                        column: x => x.BeneficiarioId,
                        principalTable: "Beneficiario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeneficiarioId = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doacoes_Beneficiario_BeneficiarioId",
                        column: x => x.BeneficiarioId,
                        principalTable: "Beneficiario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dependentes_BeneficiarioId",
                table: "Dependentes",
                column: "BeneficiarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Doacoes_BeneficiarioId",
                table: "Doacoes",
                column: "BeneficiarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dependentes");

            migrationBuilder.DropTable(
                name: "Doacoes");

            migrationBuilder.DropTable(
                name: "Beneficiario");
        }
    }
}
