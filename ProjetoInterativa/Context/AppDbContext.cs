using Microsoft.EntityFrameworkCore;
using ProjetoInterativa.Models;

namespace ProjetoInterativa.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Fabricante> Fabricantes{ get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
