using System.ComponentModel.DataAnnotations;

namespace GerenciadorCondominios.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

    }
}
