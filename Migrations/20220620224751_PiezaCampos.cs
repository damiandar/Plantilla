using Microsoft.EntityFrameworkCore.Migrations;

namespace AccesoriosArgentinos.Migrations
{
    public partial class PiezaCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PosicionExpulsor",
                table: "Piezas",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Succion",
                table: "Piezas",
                type: "nvarchar(50)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PosicionExpulsor",
                table: "Piezas");

            migrationBuilder.DropColumn(
                name: "Succion",
                table: "Piezas");
        }
    }
}
