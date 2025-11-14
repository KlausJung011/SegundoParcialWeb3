using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebApi.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;
        [Required, MaxLength(500)]
        public string Descripcion { get; set; } = string.Empty;

        public ICollection<Producto>? Productos { get; set; }
    }
}
