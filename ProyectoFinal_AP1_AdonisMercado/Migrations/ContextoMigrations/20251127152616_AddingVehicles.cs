using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoFinal_AP1_AdonisMercado.Migrations.ContextoMigrations
{
    /// <inheritdoc />
    public partial class AddingVehicles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                column: "NumeroChasis",
                value: "JTDBR32E720045671");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                column: "NumeroChasis",
                value: "2HGFA16598H345612");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                column: "NumeroChasis",
                value: "1FAHP3F26CL123589");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                column: "NumeroChasis",
                value: "1GNSKCKC4FR367812");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                column: "NumeroChasis",
                value: "MR0HA3CD205123678");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                column: "NumeroChasis",
                value: "3N1AB8CV4PY245781");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                column: "NumeroChasis",
                value: "5J6RM4H77GL046821");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                column: "NumeroChasis",
                value: "JM3KFBDM4M0557812");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                column: "NumeroChasis",
                value: "JTMGB3FV2MD062345");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                column: "NumeroChasis",
                value: "1GCUYDED2MZ234567");

            migrationBuilder.InsertData(
                table: "Vehiculos",
                columns: new[] { "VehiculoId", "AnioFabricacion", "ColorVehiculo", "EstadoVehiculo", "MarcaVehiculo", "ModeloVehiculo", "NumeroChasis", "Precio", "TipoCombustible" },
                values: new object[,]
                {
                    { 11, 2026, "Gris", "Nuevo", "Toyota", "RAV4", "2T3J1RFV7RW345612", 80000m, "Gasolina" },
                    { 12, 2026, "Gris", "Nuevo", "Kia", "K5", "5XXG64J20MG152487", 59000m, "Gasolina" },
                    { 13, 2024, "Sky Blue", "Usado", "Honda", "Pilot", "5FNYF6H56LB123789", 6000m, "Gasolina" },
                    { 14, 2026, "Rojo", "Nuevo", "Toyota", "Tacoma TRD Pro", "3TMCZ5AN8PM234981", 120000m, "Gasolina" },
                    { 15, 2026, "Storm Cloud", "Nuevo", "Toyota", "Highlander", "5TDKDRBH4PS145678", 110000m, "Gasolina" },
                    { 16, 2025, "Blanco", "Usado", "JETOUR", "Dashing", "L6T743DF5RA012345", 38000m, "Gasolina" },
                    { 17, 2025, "Blanco", "Nuevo", "Hyundai", "Sonata", "5NPEJ4J27MH045612", 40000m, "Gasolina" },
                    { 18, 2026, "Blanco", "Nuevo", "Kia", "Sonet", "MZK123F47RN654321", 35000m, "Gasolina" },
                    { 19, 2025, "Blanco", "Nuevo", "Mercedes-Benz", "GLE 63 S Coupe", "4JGED7FB7MA123456", 165000.00m, "Gasolina" },
                    { 20, 2025, "Gris", "Nuevo", "Nissan", "Frontier Pro-4X", "1N6ED1EK9RN345678", 55000m, "Diesel" },
                    { 21, 2025, "Blanco", "Usado", "Toyota", "Land Cruiser Prado Premium", "JTEBR3FJ3RK128945", 90000m, "Gasolina" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                column: "NumeroChasis",
                value: "ABC123XYZ456");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                column: "NumeroChasis",
                value: "DEF456UVW789");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                column: "NumeroChasis",
                value: "GHI789RST012");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                column: "NumeroChasis",
                value: "JKL423123444");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                column: "NumeroChasis",
                value: "MNO321XYZ654");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                column: "NumeroChasis",
                value: "PQR654UVW321");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                column: "NumeroChasis",
                value: "STU987RST654");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                column: "NumeroChasis",
                value: "VWX123LMN789");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                column: "NumeroChasis",
                value: "YZA456OPQ123");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                column: "NumeroChasis",
                value: "BCD789EFG456");
        }
    }
}
