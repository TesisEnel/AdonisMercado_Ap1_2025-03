using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoFinal_AP1_AdonisMercado.Migrations.ContextoMigrations
{
    /// <inheritdoc />
    public partial class AddModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distribuidores",
                columns: table => new
                {
                    DistribuidorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuidores", x => x.DistribuidorId);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarcaVehiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeloVehiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorVehiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroChasis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnioFabricacion = table.Column<int>(type: "int", nullable: false),
                    EstadoVehiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoCombustible = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.VehiculoId);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombrePedido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistribuidorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_Pedidos_Distribuidores_DistribuidorId",
                        column: x => x.DistribuidorId,
                        principalTable: "Distribuidores",
                        principalColumn: "DistribuidorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    DocumentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.DocumentoId);
                    table.ForeignKey(
                        name: "FK_Documentos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidoDetalles",
                columns: table => new
                {
                    PedidoDetalleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoDetalles", x => x.PedidoDetalleId);
                    table.ForeignKey(
                        name: "FK_PedidoDetalles_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoDetalles_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "VehiculoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Vehiculos",
                columns: new[] { "VehiculoId", "AnioFabricacion", "ColorVehiculo", "EstadoVehiculo", "MarcaVehiculo", "ModeloVehiculo", "NumeroChasis", "Precio", "TipoCombustible" },
                values: new object[,]
                {
                    { 1, 2020, "Blanco", "Nuevo", "Toyota", "Corolla", "ABC123XYZ456", 20000.00m, "Gasolina" },
                    { 2, 2019, "Negro", "Usado", "Honda", "Civic", "DEF456UVW789", 18000.00m, "Gasolina" },
                    { 3, 2018, "Azul", "Usado", "Ford", "Focus", "GHI789RST012", 15000.00m, "Diésel" },
                    { 4, 2025, "Rojo", "Nuevo", "Chevrolet", "Tahoe", "JKL423123444", 115000.00m, "Gasolina" },
                    { 5, 2024, "Gris", "Nuevo", "Toyota", "Hilux", "MNO321XYZ654", 52000.00m, "Diesel" },
                    { 6, 2023, "Blanco", "Nuevo", "Nissan", "Sentra", "PQR654UVW321", 22000.00m, "Gasolina" },
                    { 7, 2025, "Azul", "Nuevo", "Honda", "CR-V", "STU987RST654", 55000.00m, "Gasolina" },
                    { 8, 2024, "Rojo", "Nuevo", "Mazda", "CX-5", "VWX123LMN789", 48000.00m, "Gasolina" },
                    { 9, 2023, "Blanco", "Usado", "Toyota", "RAV4 Hybrid", "YZA456OPQ123", 35000.00m, "Gasolina" },
                    { 10, 2022, "Negro", "Usado", "Chevrolet", "Silverado", "BCD789EFG456", 60000.00m, "Diesel" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_PedidoId",
                table: "Documentos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDetalles_PedidoId",
                table: "PedidoDetalles",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDetalles_VehiculoId",
                table: "PedidoDetalles",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_DistribuidorId",
                table: "Pedidos",
                column: "DistribuidorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "PedidoDetalles");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Distribuidores");
        }
    }
}
