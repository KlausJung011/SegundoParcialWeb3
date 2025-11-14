using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SegundoParcialWebApi.Models.DTOs;
using SegundoParcialWebApi.Services;

namespace SegundoParcialWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoService _productoService;
        public ProductoController(ProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet("obtener")]
        public async Task<IActionResult> Obtener()
        {
            try
            {
                var producto = await _productoService.GetAllProductosAsync();
                return Ok(producto);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet("obtenerNombre/{nombre}")]
        public async Task<IActionResult> GetByIdV2(string nombre)
        {
            try
            {
                var producto = await _productoService.GetProductoProNombreAsync(nombre);
                if (producto == null)
                    return NotFound(new { error = "Usuario no encontrado" });

                return Ok(producto);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterProductoDto dto)
        {
            try
            {
                var producto = await _productoService.RegisterProductoAsync(dto);
                return Ok(new { message = "Producto creado", producto.Id, producto.Nombre });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateProductoDto dto)
        {
            try
            {
                var producto = await _productoService.UpdateProductoAsync(dto);
                return Ok(new { message = "Producto actualizado", producto });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(DeleteProductoDto dto)
        {
            try
            {
                await _productoService.DeleteProductoAsync(dto.Id);
                return Ok(new { message = "Producto eliminado" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
