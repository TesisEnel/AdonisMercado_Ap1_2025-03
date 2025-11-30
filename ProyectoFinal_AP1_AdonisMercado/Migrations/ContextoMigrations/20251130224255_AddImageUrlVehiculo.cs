using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_AP1_AdonisMercado.Migrations.ContextoMigrations
{
    /// <inheritdoc />
    public partial class AddImageUrlVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagenUrl",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 11,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 12,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 13,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 14,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 15,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 16,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 17,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 18,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 19,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 20,
                column: "ImagenUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 21,
                column: "ImagenUrl",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenUrl",
                table: "Vehiculos");
        }
    }
}
