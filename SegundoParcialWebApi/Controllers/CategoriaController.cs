using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SegundoParcialWebApi.Models.DTOs;
using SegundoParcialWebApi.Services;

namespace SegundoParcialWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly CategoriaService _categoriaService;
        public CategoriaController(ProductoService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet("obtener")]
        public async Task<IActionResult> Obtener()
        {
            try
            {
                var categoria = await _categoriaService.GetAllCategoriasAsync();
                return Ok(categoria);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterCategoriaDto dto)
        {
            try
            {
                var categoria = await _categoriaService.RegisterProductoAsync(dto);
                return Ok(new { message = "Categoria creado", categoria.Id, categoria.Nombre });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
