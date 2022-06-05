using Microsoft.EntityFrameworkCore.Migrations;

namespace AccesoriosArgentinos.Migrations
{
    public partial class CambiosPieza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TiempoDeInyeccion",
                table: "Piezas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Carga",
                table: "Piezas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Calefaccion",
                table: "Piezas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "InyectoraId",
                table: "Piezas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piezas_InyectoraId",
                table: "Piezas",
                column: "InyectoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Piezas_Inyectoras_InyectoraId",
                table: "Piezas",
                column: "InyectoraId",
                principalTable: "Inyectoras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Piezas_Inyectoras_InyectoraId",
                table: "Piezas");

            migrationBuilder.DropIndex(
                name: "IX_Piezas_InyectoraId",
                table: "Piezas");

            migrationBuilder.DropColumn(
                name: "InyectoraId",
                table: "Piezas");

            migrationBuilder.AlterColumn<int>(
                name: "TiempoDeInyeccion",
                table: "Piezas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Carga",
                table: "Piezas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Calefaccion",
                table: "Piezas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
