using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebApi.Models.DTOs
{
    public class RegisterProveedorDto
    {
        [Required, MaxLength(100)]
        public string RazonSocial { get; set; } = string.Empty;
        [Required, MaxLength(100)]
        public string Contacto { get; set; } = string.Empty;
    }
}
