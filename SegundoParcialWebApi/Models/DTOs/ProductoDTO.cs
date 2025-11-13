using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebApi.Models.DTOs
{
    public class RegisterProductoDto
    {
        [Required, MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;
        [Required, MaxLength(200)]
        public string DescripcionCorta { get; set; } = string.Empty;
        [Required]
        public double Precio { get; set; } = double.NaN;
        [Required]
        public int Stock { get; set; } = 0;
        public int IdCategoria { get; set; }
        public int IdProveedor { get; set; }
    }

    public class UpdateProductoDto
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;
        [MaxLength(200)]
        public string DescripcionCorta { get; set; } = string.Empty;
        public double Precio { get; set; } = double.NaN;
        public int Stock { get; set; } = 0;
    }

    public class DeleteProductoDto
    {
        public int Id { get; set; }
    }

}
