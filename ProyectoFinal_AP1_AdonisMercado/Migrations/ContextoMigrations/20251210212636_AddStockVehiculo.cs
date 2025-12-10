using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_AP1_AdonisMercado.Migrations.ContextoMigrations
{
    /// <inheritdoc />
    public partial class AddStockVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockVehiculo",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                column: "StockVehiculo",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                column: "StockVehiculo",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                column: "StockVehiculo",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                column: "StockVehiculo",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                column: "StockVehiculo",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                column: "StockVehiculo",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                column: "StockVehiculo",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                column: "StockVehiculo",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                column: "StockVehiculo",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                column: "StockVehiculo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 11,
                column: "StockVehiculo",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 12,
                column: "StockVehiculo",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 13,
                column: "StockVehiculo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 14,
                column: "StockVehiculo",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 15,
                column: "StockVehiculo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 16,
                column: "StockVehiculo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 17,
                column: "StockVehiculo",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 18,
                column: "StockVehiculo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 19,
                column: "StockVehiculo",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 20,
                column: "StockVehiculo",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 21,
                column: "StockVehiculo",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockVehiculo",
                table: "Vehiculos");
        }
    }
}
