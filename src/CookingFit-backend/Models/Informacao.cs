using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingFit_backend.Models
{
    [Table("Informacoes")]
    public class Informacao
    {
        [Key]
        [Required(ErrorMessage = "Obrigatório informar o campo !")]
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o campo !")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o campo !")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DtNasc { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o campo !")]
        public string Genero { get; set; }

        public string Telefone { get; set; }

        [Display(Name = "Formação Acadêmica")]
        public string FormAcademica { get; set; }

        [Display(Name = "Hobby")]
        public string Biografia { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar o campo !")]
        [Display(Name = "Aonde me achar!")]
        public string Link { get; set; }
    }
}

