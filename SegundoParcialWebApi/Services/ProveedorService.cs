using SegundoParcialWebApi.Data;
using SegundoParcialWebApi.Models;
using SegundoParcialWebApi.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace SegundoParcialWebApi.Services
{
    public class ProveedorService
    {
        private readonly AppDbContext _appDbContext;
        public ProveedorService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Proveedor>> GetAllProveedoresAsync()
        {
            var proveedor = _appDbContext.Proveedores.ToListAsync();
            return await proveedor;
        }

        public async Task<Proveedor> RegisterProductoAsync(RegisterProveedorDto dto)
        {
            var proveedor = new Proveedor
            {
                RazonSocial = dto.RazonSocial,
                Contacto = dto.Contacto
            };

            _appDbContext.Proveedores.Add(proveedor);
            await _appDbContext.SaveChangesAsync();
            return proveedor;
        }
    }
}
