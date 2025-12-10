using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal_AP1_AdonisMercado.Models;

public class Vehiculo
{
    [Key]
    public int VehiculoId { get; set; }

    [Required(ErrorMessage = "La marca es obligatoria.")]
    [RegularExpression(@"^[a-zA-ZÁÉÍÓÚáéíóúñÑ ]+$", ErrorMessage = "Marca incorrecta. Solo se permite usar letras.")]
    public string MarcaVehiculo { get; set; } = string.Empty;

    [Required(ErrorMessage = "El modelo es obligatorio.")]
    [RegularExpression(@"^[a-zA-ZÁÉÍÓÚáéíóúñÑ0-9 ]+$", ErrorMessage = "Modelo incorrecto. Solo se permite usar letras y números.")]
    public string ModeloVehiculo { get; set; } = string.Empty;

    [Required(ErrorMessage = "El color es obligatorio.")]
    [RegularExpression(@"^[a-zA-ZÁÉÍÓÚáéíóúñÑ ]+$", ErrorMessage = "Color incorrecto. Solo se permite usar letras.")]
    public string ColorVehiculo { get; set; } = string.Empty;

    [Required(ErrorMessage = "El número de chasis es obligatorio.")]
    [RegularExpression(@"^[A-Za-z0-9]+$", ErrorMessage = "Número de chasis inválido. Solo se permite usar letras y números.")]
    public string NumeroChasis { get; set; } = string.Empty;

    [Required(ErrorMessage = "El año de fabricacion es obligatorio.")]
    [Range(0, int.MaxValue, ErrorMessage = "El año de fabricacion debe ser mayor que 0.")]
    public int? AnioFabricacion { get; set; }

    [Required(ErrorMessage = "El motor es obligatorio.")]
    public string Motor { get; set; } = string.Empty;

    [Required(ErrorMessage = "La transmision es obligatoria.")]
    public string Transmision { get; set; } = string.Empty;

    [Required(ErrorMessage = "La traccion es obligatoria.")]
    public string Traccion { get; set; } = string.Empty;

    [Required(ErrorMessage = "El numero de puertas es obligatorio.")]
    [Range(1, 10, ErrorMessage = "El numero de puertas debe se un numero entre 1 y 10.")]
    public int? NumeroPuertas { get; set; }

    [Required(ErrorMessage = "El kilometraje es obligatorio.")]
    [Range(0, int.MaxValue, ErrorMessage = "El kilometraje es obligatorio")]
    public int? Kilometraje { get; set; }

    [Required(ErrorMessage = "El estado es obligatorio.")]
    public string EstadoVehiculo { get; set; } = string.Empty;

    [Required(ErrorMessage = "El tipo de combustible es obligatorio.")]
    public string TipoCombustible { get; set; } = string.Empty;

    [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")]
    public decimal Precio { get; set; }

    public bool isActive { get; set; } = true;
    public string? ImagenUrl { get; set; }

    [InverseProperty("Vehiculo")]
    public ICollection<PedidoDetalle> PedidoDetalles { get; set; } = new List<PedidoDetalle>();
}
