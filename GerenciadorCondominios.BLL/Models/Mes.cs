using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    [Table("Meses")]
    public class Mes
    {
        public int MesId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Aluguel> Alugueis { get; set; }
        public virtual ICollection<HistoricoRecurso> HistoricoRecursos { get; set; }
        
    }
}
