using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projectweb1.Migrations
{
    /// <inheritdoc />
    public partial class Fixinitial_backcup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Departamento",
                table: "Empleado",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Horario",
                table: "Empleado",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Posicion",
                table: "Empleado",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Sueldo",
                table: "Empleado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Telefono",
                table: "Empleado",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Departamento",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "Horario",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "Posicion",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "Sueldo",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Empleado");
        }
    }
}
