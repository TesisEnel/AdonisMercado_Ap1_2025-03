using Microsoft.EntityFrameworkCore;
using ProyectoFinal_AP1_AdonisMercado.Models;

namespace ProyectoFinal_AP1_AdonisMercado.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Distribuidor> Distribuidores { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<PedidoDetalle> PedidoDetalles { get; set; }
    public DbSet<Vehiculo> Vehiculos { get; set; }
    public DbSet<Documento> Documentos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Vehiculo>().HasData(
            new Vehiculo
            {
                VehiculoId = 1,
                MarcaVehiculo = "Toyota",
                ModeloVehiculo = "Corolla",
                ColorVehiculo = "Blanco",
                NumeroChasis = "JTDBR32E720045671",
                AnioFabricacion = 2020,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Gasolina",
                Precio = 20000.00m,
                Transmision = "Automática",
                Traccion = "FWD",
                Motor = "1.8L",
                Kilometraje = 0,
                NumeroPuertas = 4
            },
            new Vehiculo
            {
                VehiculoId = 2,
                MarcaVehiculo = "Honda",
                ModeloVehiculo = "Civic",
                ColorVehiculo = "Negro",
                NumeroChasis = "2HGFA16598H345612",
                AnioFabricacion = 2019,
                EstadoVehiculo = "Usado",
                TipoCombustible = "Gasolina",
                Precio = 18000.00m,
                Transmision = "Automática",
                Traccion = "FWD",
                Motor = "2.0L",
                Kilometraje = 45000,
                NumeroPuertas = 4
            },
            new Vehiculo
            {
                VehiculoId = 3,
                MarcaVehiculo = "Ford",
                ModeloVehiculo = "Focus",
                ColorVehiculo = "Azul",
                NumeroChasis = "1FAHP3F26CL123589",
                AnioFabricacion = 2018,
                EstadoVehiculo = "Usado",
                TipoCombustible = "Diésel",
                Precio = 15000.00m,
                Transmision = "Manual",
                Traccion = "FWD",
                Motor = "2.0L TDCi",
                Kilometraje = 60000,
                NumeroPuertas = 4
            },
            new Vehiculo
            {
                VehiculoId = 4,
                MarcaVehiculo = "Chevrolet",
                ModeloVehiculo = "Tahoe",
                ColorVehiculo = "Rojo",
                NumeroChasis = "1GNSKCKC4FR367812",
                AnioFabricacion = 2025,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Gasolina",
                Precio = 115000.00m,
                Transmision = "Automática",
                Traccion = "4x4",
                Motor = "5.3L V8",
                Kilometraje = 0,
                NumeroPuertas = 5
            },
            new Vehiculo
            {
                VehiculoId = 5,
                MarcaVehiculo = "Toyota",
                ModeloVehiculo = "Hilux",
                ColorVehiculo = "Gris",
                NumeroChasis = "MR0HA3CD205123678",
                AnioFabricacion = 2024,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Diesel",
                Precio = 52000.00m,
                Transmision = "Automática",
                Traccion = "4x4",
                Motor = "2.8L Turbo Diesel",
                Kilometraje = 0,
                NumeroPuertas = 4
            },
            new Vehiculo
            {
                VehiculoId = 6,
                MarcaVehiculo = "Nissan",
                ModeloVehiculo = "Sentra",
                ColorVehiculo = "Blanco",
                NumeroChasis = "3N1AB8CV4PY245781",
                AnioFabricacion = 2023,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Gasolina",
                Precio = 22000.00m,
                Transmision = "CVT",
                Traccion = "FWD",
                Motor = "2.0L",
                Kilometraje = 0,
                NumeroPuertas = 4
            },
            new Vehiculo
            {
                VehiculoId = 7,
                MarcaVehiculo = "Honda",
                ModeloVehiculo = "CR-V",
                ColorVehiculo = "Azul",
                NumeroChasis = "5J6RM4H77GL046821",
                AnioFabricacion = 2025,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Gasolina",
                Precio = 55000.00m,
                Transmision = "Automática",
                Traccion = "AWD",
                Motor = "1.5L Turbo",
                Kilometraje = 0,
                NumeroPuertas = 5
            },
            new Vehiculo
            {
                VehiculoId = 8,
                MarcaVehiculo = "Mazda",
                ModeloVehiculo = "CX-5",
                ColorVehiculo = "Rojo",
                NumeroChasis = "JM3KFBDM4M0557812",
                AnioFabricacion = 2024,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Gasolina",
                Precio = 48000.00m,
                Transmision = "Automática",
                Traccion = "AWD",
                Motor = "2.5L SkyActiv",
                Kilometraje = 0,
                NumeroPuertas = 5
            },
            new Vehiculo
            {
                VehiculoId = 9,
                MarcaVehiculo = "Toyota",
                ModeloVehiculo = "RAV4 Hybrid",
                ColorVehiculo = "Blanco",
                NumeroChasis = "JTMGB3FV2MD062345",
                AnioFabricacion = 2023,
                EstadoVehiculo = "Usado",
                TipoCombustible = "Gasolina",
                Precio = 35000.00m,
                Transmision = "Automática",
                Traccion = "AWD",
                Motor = "2.5L Hybrid",
                Kilometraje = 20000,
                NumeroPuertas = 5
            },
            new Vehiculo
            {
                VehiculoId = 10,
                MarcaVehiculo = "Chevrolet",
                ModeloVehiculo = "Silverado",
                ColorVehiculo = "Negro",
                NumeroChasis = "1GCUYDED2MZ234567",
                AnioFabricacion = 2022,
                EstadoVehiculo = "Usado",
                TipoCombustible = "Diesel",
                Precio = 60000.00m,
                Transmision = "Automática",
                Traccion = "4x4",
                Motor = "3.0L Duramax",
                Kilometraje = 35000,
                NumeroPuertas = 4
            },
            new Vehiculo
            {
                VehiculoId = 11,
                MarcaVehiculo = "Toyota",
                ModeloVehiculo = "RAV4",
                ColorVehiculo = "Gris",
                NumeroChasis = "2T3J1RFV7RW345612",
                AnioFabricacion = 2026,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Gasolina",
                Precio = 80000m,
                Transmision = "Automática",
                Traccion = "AWD",
                Motor = "2.5L",
                Kilometraje = 0,
                NumeroPuertas = 5
            },
            new Vehiculo
            {
                VehiculoId = 12,
                MarcaVehiculo = "Kia",
                ModeloVehiculo = "K5",
                ColorVehiculo = "Gris",
                NumeroChasis = "5XXG64J20MG152487",
                AnioFabricacion = 2026,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Gasolina",
                Precio = 59000m,
                Transmision = "Automática",
                Traccion = "FWD",
                Motor = "1.6L Turbo",
                Kilometraje = 0,
                NumeroPuertas = 4
            },
            new Vehiculo
            {
                VehiculoId = 13,
                MarcaVehiculo = "Honda",
                ModeloVehiculo = "Pilot",
                ColorVehiculo = "Sky Blue",
                NumeroChasis = "5FNYF6H56LB123789",
                AnioFabricacion = 2024,
                EstadoVehiculo = "Usado",
                TipoCombustible = "Gasolina",
                Precio = 6000m,
                Transmision = "Automática",
                Traccion = "AWD",
                Motor = "3.5L V6",
                Kilometraje = 70000,
                NumeroPuertas = 5
            },
            new Vehiculo
            {
                VehiculoId = 14,
                MarcaVehiculo = "Toyota",
                ModeloVehiculo = "Tacoma TRD Pro",
                ColorVehiculo = "Rojo",
                NumeroChasis = "3TMCZ5AN8PM234981",
                AnioFabricacion = 2026,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Gasolina",
                Precio = 120000m,
                Transmision = "Automática",
                Traccion = "4x4",
                Motor = "3.5L V6",
                Kilometraje = 0,
                NumeroPuertas = 4
            },
            new Vehiculo
            {
                VehiculoId = 15,
                MarcaVehiculo = "Toyota",
                ModeloVehiculo = "Highlander",
                ColorVehiculo = "Storm Cloud",
                NumeroChasis = "5TDKDRBH4PS145678",
                AnioFabricacion = 2026,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Gasolina",
                Precio = 110000m,
                Transmision = "Automática",
                Traccion = "AWD",
                Motor = "3.5L V6",
                Kilometraje = 0,
                NumeroPuertas = 5
            },
            new Vehiculo
            {
                VehiculoId = 16,
                MarcaVehiculo = "JETOUR",
                ModeloVehiculo = "Dashing",
                ColorVehiculo = "Blanco",
                NumeroChasis = "L6T743DF5RA012345",
                AnioFabricacion = 2025,
                EstadoVehiculo = "Usado",
                TipoCombustible = "Gasolina",
                Precio = 38000m,
                Transmision = "Automática",
                Traccion = "FWD",
                Motor = "1.5L Turbo",
                Kilometraje = 15000,
                NumeroPuertas = 5
            },
            new Vehiculo
            {
                VehiculoId = 17,
                MarcaVehiculo = "Hyundai",
                ModeloVehiculo = "Sonata",
                ColorVehiculo = "Blanco",
                NumeroChasis = "5NPEJ4J27MH045612",
                AnioFabricacion = 2025,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Gasolina",
                Precio = 40000m,
                Transmision = "Automática",
                Traccion = "FWD",
                Motor = "2.5L",
                Kilometraje = 0,
                NumeroPuertas = 4
            },
            new Vehiculo
            {
                VehiculoId = 18,
                MarcaVehiculo = "Kia",
                ModeloVehiculo = "Sonet",
                ColorVehiculo = "Blanco",
                NumeroChasis = "MZK123F47RN654321",
                AnioFabricacion = 2026,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Gasolina",
                Precio = 35000m,
                Transmision = "Automática",
                Traccion = "FWD",
                Motor = "1.5L",
                Kilometraje = 0,
                NumeroPuertas = 4
            },
            new Vehiculo
            {
                VehiculoId = 19,
                MarcaVehiculo = "Mercedes-Benz",
                ModeloVehiculo = "GLE 63 S Coupe",
                ColorVehiculo = "Blanco",
                NumeroChasis = "4JGED7FB7MA123456",
                AnioFabricacion = 2025,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Gasolina",
                Precio = 165000.00m,
                Transmision = "Automática AMG",
                Traccion = "AWD 4MATIC",
                Motor = "4.0L V8 Biturbo",
                Kilometraje = 0,
                NumeroPuertas = 5
            },
            new Vehiculo
            {
                VehiculoId = 20,
                MarcaVehiculo = "Nissan",
                ModeloVehiculo = "Frontier Pro-4X",
                ColorVehiculo = "Gris",
                NumeroChasis = "1N6ED1EK9RN345678",
                AnioFabricacion = 2025,
                EstadoVehiculo = "Nuevo",
                TipoCombustible = "Diesel",
                Precio = 55000m,
                Transmision = "Automática",
                Traccion = "4x4",
                Motor = "2.5L Turbo Diesel",
                Kilometraje = 0,
                NumeroPuertas = 4
            },
            new Vehiculo
            {
                VehiculoId = 21,
                MarcaVehiculo = "Toyota",
                ModeloVehiculo = "Land Cruiser Prado Premium",
                ColorVehiculo = "Blanco",
                NumeroChasis = "JTEBR3FJ3RK128945",
                AnioFabricacion = 2025,
                EstadoVehiculo = "Usado",
                TipoCombustible = "Gasolina",
                Precio = 90000m,
                Transmision = "Automática",
                Traccion = "4x4",
                Motor = "4.0L V6",
                Kilometraje = 10000,
                NumeroPuertas = 5
            }
        );
    }
}
