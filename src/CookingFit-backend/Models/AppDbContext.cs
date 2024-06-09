using Microsoft.EntityFrameworkCore;
using CookingFit_backend.Models;

namespace CookingFit_backend.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ingrediente> Ingrediente { get; set; }

        public DbSet<TipoIngrediente> TipoIngrediente { get; set; }

        public DbSet<Cardapio> Cardapios { get; set; }

        public DbSet<Informacao> InfoUser { get; set; }

        public DbSet<Receita> Receitas{ get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoCardapio> TipoCardapio { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingrediente>()
                .HasOne(i => i.TipoIngrediente)
                .WithMany(t => t.Ingrediente)
                .HasForeignKey(i => i.TipoIngredienteId);
            modelBuilder.Entity<Cardapio>().HasKey(c => c.Id);
        }

        public DbSet<ItemCardapio> ItemCardapio { get; set; }

    }
}
