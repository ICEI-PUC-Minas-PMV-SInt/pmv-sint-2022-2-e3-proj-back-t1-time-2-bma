using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cadastro_beneficiario.Migrations
{
    public partial class M03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "complemento",
                table: "Beneficiario",
                newName: "Complemento");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Beneficiario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "Beneficiario",
                newName: "complemento");

            migrationBuilder.AlterColumn<string>(
                name: "complemento",
                table: "Beneficiario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
