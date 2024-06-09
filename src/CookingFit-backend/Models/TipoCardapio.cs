using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingFit_backend.Models
{
    public class TipoCardapio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório selecionar o Tipo!")]
        public string? Tipo { get; set; }

        [NotMapped]
        // Propriedade de navegação inversa
        public ICollection<ItemCardapio>? ItemCardapio { get; set; }

    }
}
