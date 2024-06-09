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
        public int QuantidadeCardapio { get; set; }


        // Definida chave estrangeira para a tabela Usuário
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        // Propriedade de navegação para a relação
        public Usuario Usuario { get; set; }

        [NotMapped]
        [Display(Name = "Calorias contidas no cardápio.")]
        public int CaloriasCardapio { get; set; }



    }
}
