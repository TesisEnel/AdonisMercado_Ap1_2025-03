using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_AP1_AdonisMercado.Migrations.ContextoMigrations
{
    /// <inheritdoc />
    public partial class AddCamposVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Kilometraje",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Motor",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroPuertas",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Traccion",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Transmision",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "1.8L", 4, "FWD", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 45000, "2.0L", 4, "FWD", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 60000, "2.0L TDCi", 4, "FWD", "Manual" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "5.3L V8", 5, "4x4", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "2.8L Turbo Diesel", 4, "4x4", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "2.0L", 4, "FWD", "CVT" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "1.5L Turbo", 5, "AWD", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "2.5L SkyActiv", 5, "AWD", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 20000, "2.5L Hybrid", 5, "AWD", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 35000, "3.0L Duramax", 4, "4x4", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 11,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "2.5L", 5, "AWD", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 12,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "1.6L Turbo", 4, "FWD", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 13,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 70000, "3.5L V6", 5, "AWD", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 14,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "3.5L V6", 4, "4x4", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 15,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "3.5L V6", 5, "AWD", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 16,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 15000, "1.5L Turbo", 5, "FWD", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 17,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "2.5L", 4, "FWD", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 18,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "1.5L", 4, "FWD", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 19,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "4.0L V8 Biturbo", 5, "AWD 4MATIC", "Automática AMG" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 20,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 0, "2.5L Turbo Diesel", 4, "4x4", "Automática" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 21,
                columns: new[] { "Kilometraje", "Motor", "NumeroPuertas", "Traccion", "Transmision" },
                values: new object[] { 10000, "4.0L V6", 5, "4x4", "Automática" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kilometraje",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Motor",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "NumeroPuertas",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Traccion",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Transmision",
                table: "Vehiculos");
        }
    }
}
