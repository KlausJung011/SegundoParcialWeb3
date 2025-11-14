using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SegundoParcialWebApi.Data;
using SegundoParcialWebApi.Models;
using SegundoParcialWebApi.Models.DTOs;
using System.Text;


namespace SegundoParcialWebApi.Services
{
    public class ProductoService
    {
        private readonly AppDbContext _appDbContext;
        public ProductoService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Producto>> GetAllProductosAsync()
        {
            var producto = _appDbContext.Productos.ToListAsync();
            return await producto;
        }

        public async Task<Producto?> GetProductoProNombreAsync(string name)
        {
            var producto = await _appDbContext.Productos.FindAsync(name);
            if (producto == null)
                throw new Exception("Producto no encontrado");

            return producto;
        }

        public async Task<Producto> RegisterProductoAsync(RegisterProductoDto dto)
        {
            var producto = new Producto
            {
                Nombre = dto.Nombre,
                DescripcionCorta = dto.DescripcionCorta,
                Precio = dto.Precio,
                Stock = dto.Stock,
                IdCategoria = dto.IdCategoria,
                IdProveedor = dto.IdProveedor,
            };

            _appDbContext.Productos.Add(producto);
            await _appDbContext.SaveChangesAsync();
            return producto;
        }

        public async Task<Producto> UpdateProductoAsync(UpdateProductoDto dto)
        {
            var producto = await _appDbContext.Productos.FindAsync(dto.Id);
            if (producto == null)
                throw new Exception("Producto no encontrado");

            if (!string.IsNullOrEmpty(dto.Nombre))
                producto.Nombre = dto.Nombre;

            if (!string.IsNullOrEmpty(dto.DescripcionCorta))
                producto.DescripcionCorta = dto.DescripcionCorta;

            if (dto.Precio < 0.1)
                producto.Precio = dto.Precio;

            if (dto.Stock < 0)
                producto.Precio = dto.Precio;

            await _appDbContext.SaveChangesAsync();
            return producto;
        }

        public async Task DeleteProductoAsync(int id)
        {
            var producto = await _appDbContext.Productos.FindAsync(id);
            if (producto == null)
                throw new Exception("Producto no encontrado");

            _appDbContext.Productos.Remove(producto);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
