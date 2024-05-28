using Microsoft.EntityFrameworkCore;

namespace CookingFit_backend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<TipoIngrediente> TipoIngrediente { get; set; }
        public DbSet<Cardapio> Cardapio { get; set; }
        public DbSet<Informacao> InfoUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingrediente>()
                .HasOne(i => i.TipoIngrediente)
                .WithMany(t => t.Ingredientes)
                .HasForeignKey(i => i.TipoIngredienteId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
