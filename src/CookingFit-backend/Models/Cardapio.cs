using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CookingFit_backend.Models
{
    [Table("Cardapio")]
    public class Cardapio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informar a descrição!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informar a quantidade!")]
        public int Quantidade { get; set; }

        // Propriedade de navegação para os ingredientes associados
        public List<Ingrediente> IngredientesAssociados { get; set; }

        // Definida chave estrangeira para a tabela Usuário
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        // Propriedade de navegação para a relação
        public Usuario Usuario { get; set; }

        [NotMapped]
        [Display(Name = "Calorias contidas no cardápio.")]
        public int CaloriasCardapio
        {
            get
            {
                if (IngredientesAssociados != null && IngredientesAssociados.Any())
                {
                    return IngredientesAssociados.Sum(i => i.Calorias);
                }
                return 0;
            }
        }

        [NotMapped]
        public List<SelectListItem> Ingredientes { get; set; }

        [NotMapped]
        public List<SelectListItem> Cardapios { get; set; }

        [NotMapped]
        public List<int> IngredientesIds { get; set; }
    }
}
