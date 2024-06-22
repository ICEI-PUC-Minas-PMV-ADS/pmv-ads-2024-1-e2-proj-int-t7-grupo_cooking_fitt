using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingFit_backend.Models
{
    public class ItemCardapio
    {
        [Key]
        public int Id { get; set; }

        public int CaloriasItem { get; set; }

        public int Quantidade { get; set; }

        public int TotalCalorico => Quantidade * CaloriasItem;


        [ForeignKey("TipoIngrediente")]
        public int TipoIngredienteIdItem { get; set; }
        public TipoIngrediente TipoIngrediente { get; set; }

        [ForeignKey("TipoCardapio")]
        public int TipoCardapioId { get; set; }

        // Propriedade de navegação para a relação
        public TipoCardapio TipoCardapio { get; set; }

        [ForeignKey("Ingrediente")]
        public int IngredienteId_IC { get; set; }
        public Ingrediente Ingrediente { get; set; }



    }
}
