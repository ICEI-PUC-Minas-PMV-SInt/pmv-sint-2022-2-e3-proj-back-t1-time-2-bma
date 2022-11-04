using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cadastro_beneficiario.Migrations
{
    public partial class M04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Cesta_Verde",
                table: "Beneficiario",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cesta_basica",
                table: "Beneficiario",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cesta_Verde",
                table: "Beneficiario");

            migrationBuilder.DropColumn(
                name: "Cesta_basica",
                table: "Beneficiario");
        }
    }
}
