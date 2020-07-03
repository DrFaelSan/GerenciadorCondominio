using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorCondominios.BLL.Models
{
    [Table("Funcoes")]
    public class Funcao : IdentityRole<string>
    {
        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        [Display(Name= "Descrição")]
        public string Descricao{ get; set; }
    }

}
