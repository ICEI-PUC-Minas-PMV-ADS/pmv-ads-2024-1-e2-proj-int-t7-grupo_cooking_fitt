using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingFit_backend.Models
{
    [Table("TipoIngrediente")]
    public class TipoIngrediente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Tipo! Ex.: Carboidratos, laticínios, etc.")]
        public string Tipo { get; set; }
    }
}
