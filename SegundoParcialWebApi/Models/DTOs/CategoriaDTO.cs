using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebApi.Models.DTOs
{
    public class CategoriaDTO
    {
        public class RegisterCategoriaDto
        {
            [Required, MaxLength(100)]
            public string Nombre { get; set; } = string.Empty;
            [Required, MaxLength(500)]
            public string Descripcion { get; set; } = string.Empty;
        }
    }
}
