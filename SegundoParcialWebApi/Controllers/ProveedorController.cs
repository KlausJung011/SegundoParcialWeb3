using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SegundoParcialWebApi.Models.DTOs;
using SegundoParcialWebApi.Services;

namespace SegundoParcialWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private readonly ProveedorService _proveedorService;
        public ProveedorController(ProveedorService proveedorService)
        {
            _proveedorService = proveedorService;
        }

        [HttpGet("obtener")]
        public async Task<IActionResult> Obtener()
        {
            try
            {
                var proveedor = await _proveedorService.GetAllProveedoresAsync();
                return Ok(proveedor);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterProveedorDto dto)
        {
            try
            {
                var proveedor = await _proveedorService.RegisterProductoAsync(dto);
                return Ok(new { message = "Proveedor creado", proveedor.Id, proveedor.RazonSocial });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
