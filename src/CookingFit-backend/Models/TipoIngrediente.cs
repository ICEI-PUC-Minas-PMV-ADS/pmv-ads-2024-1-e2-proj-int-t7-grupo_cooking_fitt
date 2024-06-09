using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingFit_backend.Models
{
    [Table("TipoIngrediente")]
    public class TipoIngrediente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Tipo!")]
        public string? Tipo { get; set; }

        [NotMapped]
        // Propriedade de navegação inversa
        public ICollection<Ingrediente>? Ingrediente { get; set; }

        [NotMapped]
        // Propriedade de navegação inversa
        public ICollection<ItemCardapio>? ItemCardapio { get; set; }
    }
}
