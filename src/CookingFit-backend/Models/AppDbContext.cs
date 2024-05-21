using Microsoft.EntityFrameworkCore;
using CookingFit_backend.Models;

namespace CookingFit_backend.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ingrediente> Ingrediente { get; set; }

        public DbSet<Cardapio> Cardapio { get; set; }

        public DbSet<Informacao> InfoUser { get; set; }

        public DbSet<Comentario> Comentarios { get; set; }

        public DbSet<Receitas> Receitas { get; set; }

    }
}
