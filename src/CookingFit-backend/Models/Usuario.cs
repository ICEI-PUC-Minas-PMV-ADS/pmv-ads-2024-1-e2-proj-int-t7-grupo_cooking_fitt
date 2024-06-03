using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingFit_backend.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar a senha")]
        [DataType(DataType.Password)]
        public String Senha { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o Perfil")]
        public Perfil Perfil { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email")]
        [EmailAddress]
        public string Email { get; set; }  // Adicionada propriedade Email

        // Propriedade de navegação para a relação, associa o usuário a um cardápio específico
        public ICollection<Cardapio>? Cardapio { get; set; }
    }
    public enum Perfil
    {
        Admin,
        User
    }
}
