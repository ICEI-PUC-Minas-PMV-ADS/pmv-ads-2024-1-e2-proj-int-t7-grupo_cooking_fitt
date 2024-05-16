using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingFit_backend.Models
{
    [Table("Cardápio")]
    public class Cardapio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informar a descricao!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informar o total de calorias!")]
        public int Calorias { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informar a quantidade! (Ex.: 1 colher, meia chícara, etc.)")]
        public string Quantidade { get; set; }

    }
}