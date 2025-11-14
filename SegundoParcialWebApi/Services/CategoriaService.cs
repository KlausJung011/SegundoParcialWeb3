using SegundoParcialWebApi.Data;
using SegundoParcialWebApi.Models;
using SegundoParcialWebApi.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace SegundoParcialWebApi.Services
{
    public class CategoriaService
    {
        private readonly AppDbContext _appDbContext;
        public CategoriaService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Categoria>> GetAllCategoriasAsync()
        {
            var categoria = _appDbContext.Categorias.ToListAsync();
            return await categoria;
        }

        public async Task<Categoria> RegisterProductoAsync(RegisterCategoriaDto dto)
        {
            var categoria = new Categoria
            {
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion
            };

            _appDbContext.Categorias.Add(categoria);
            await _appDbContext.SaveChangesAsync();
            return categoria;
        }
    }
}
