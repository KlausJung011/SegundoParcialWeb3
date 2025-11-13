using Microsoft.EntityFrameworkCore;
using SegundoParcialWebApi.Models;

namespace WebAPI1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users => Set<Producto>();
        public DbSet<Rol> Roles => Set<Categoria>();
        public DbSet<Rol> Roles => Set<Proveedor>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
