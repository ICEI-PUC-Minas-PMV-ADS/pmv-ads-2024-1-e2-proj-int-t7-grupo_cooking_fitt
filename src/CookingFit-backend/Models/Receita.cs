using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingFit_backend.Models
{
    [Table("Receita")]
    public class Receita
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar os ingredientes")]
        public string Ingrediente { get; set; }
    }
}
