using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    [Table("ServicoPredios")]
    public class ServicoPredio
    {
        public int ServicoPredioId { get; set; }

        public int ServicoId { get; set; }

        public virtual Servico Servico { get; set; }

        public DateTime DataExecucao { get; set; }
    }
}
