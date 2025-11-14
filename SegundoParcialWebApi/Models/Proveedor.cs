using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebApi.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string RazonSocial { get; set; } = string.Empty;
        [Required, MaxLength(100)]
        public string Contacto { get; set; } = string.Empty;

        public ICollection<Producto>? Productos { get; set; }
    }
}
