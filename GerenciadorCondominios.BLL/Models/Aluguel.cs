using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorCondominios.BLL.Models
{
    [Table("Alugueis")]
    public class Aluguel
    {
        public int AluguelId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal Valor { get; set; }

        [Display(Name = "Mês")]
        public int MesId { get; set; }

        public Mes Mes { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(2020, 2040, ErrorMessage = "Valor inválido")]
        public int Ano { get; set; }

        public virtual ICollection<Pagamento> Pagamentos { get; set; }
    }
}
