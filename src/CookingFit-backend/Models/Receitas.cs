using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CookingFit_backend.Models
{
    [Table("Receitas")]
    public  class Receitas
    {
        [Key]   
        public int IdReceita { get; set; }
      
        public string Nome { get; set; }

        
        public string Descriçao { get; set; }
        
        public bool Ativo { get; set; }

        public virtual ICollection<Comentario> Comentarios{ get; set; } = new List<Comentario>();
    }
}
