using Microsoft.EntityFrameworkCore;
using SegundoParcialWebApi.Models;

namespace SegundoParcialWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<Categoria> Categorias => Set<Categoria>();
        public DbSet<Proveedor> Proveedores => Set<Proveedor>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
