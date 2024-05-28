using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingFit_backend.Models
{
    [Table("Ingrediente")]
    public class Ingrediente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informar a porção! (Ex.: 1 colher, meia xícara, etc.)")]
        public string Unidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informar o peso! (Ex.: 100g, 2kg, etc.)")]
        public string Peso { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informar o tipo de ingrediente!")]
        public string Tipo { get; set; }

        public int Calorias { get; set; }

        // Definindo a chave estrangeira
        public int TipoIngredienteId { get; set; }

        // Propriedade de navegação para a relação
        public TipoIngrediente TipoIngrediente { get; set; }
    }
}
