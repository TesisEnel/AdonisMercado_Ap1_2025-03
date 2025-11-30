using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_AP1_AdonisMercado.Migrations.ContextoMigrations
{
    /// <inheritdoc />
    public partial class AddIsActiveVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "Vehiculos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 11,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 12,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 13,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 14,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 15,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 16,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 17,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 18,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 19,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 20,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 21,
                column: "isActive",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Vehiculos");
        }
    }
}
