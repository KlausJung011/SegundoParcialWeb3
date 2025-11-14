using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebApi.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;
        [Required, MaxLength(200)]
        public string DescripcionCorta { get; set; } = string.Empty;
        [Required]
        public double Precio { get; set; } = double.NaN;
        [Required]
        public int Stock { get; set; } = 0;

        public int? IdCategoria { get; set; }
        public Categoria? Categoria { get; set; }

        public int? IdProveedor { get; set; }
        public Proveedor? Proveedor { get; set; }
    }
}
