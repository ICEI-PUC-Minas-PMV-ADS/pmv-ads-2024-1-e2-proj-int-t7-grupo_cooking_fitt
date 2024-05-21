using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingFit_backend.Models
{
    public class Comentario
    {
        [Key]
        public int ComentarioId { get; set; }

        [Required]
        public int Nota { get; set; }

        
        public string Texto { get; set; }

        
        public int IdReceita { get; set; }

        
        public Receitas Receita { get; set; }
    }
}