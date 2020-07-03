using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorCondominios.BLL.Models
{

    [Table("HistoricoRecursos")]
    public class HistoricoRecurso
    {

        public int HistoriocoRecursoId { get; set; }

        public decimal Valor { get; set; }

        public Tipos Tipo { get; set; }

        public int Dia { get; set; }

        public int MesId { get; set; }

        public virtual Mes Mes { get; set; }

        public int Ano { get; set; }
    }

    public enum Tipos
    {
        Entrada, Saida
    }
}
