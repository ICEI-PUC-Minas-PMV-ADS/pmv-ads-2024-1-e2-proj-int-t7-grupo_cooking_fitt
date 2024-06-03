using System.ComponentModel.DataAnnotations;

namespace CookingFit_backend.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Obrigatório informar o email.")]
        [EmailAddress(ErrorMessage = "Formato de email inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}

