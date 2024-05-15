using Microsoft.EntityFrameworkCore;

namespace CookingFit_backend.Models
{
    public class InformacaoThumbnailContext : DbContext
    {
        public InformacaoThumbnailContext(DbContextOptions<InformacaoThumbnailContext> options) : base(options) { }

        public DbSet<Informacao> Informacoes { get; set; }
        
    }
}
