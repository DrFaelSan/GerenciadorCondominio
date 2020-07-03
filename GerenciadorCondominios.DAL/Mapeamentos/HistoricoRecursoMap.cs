using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class HistoricoRecursoMap : IEntityTypeConfiguration<HistoricoRecurso>
    {
        public void Configure(EntityTypeBuilder<HistoricoRecurso> builder)
        {
            builder.HasKey(hr => hr.HistoriocoRecursoId);
            builder.Property(hr => hr.Valor).IsRequired();
            builder.Property(hr => hr.Tipo).IsRequired();
            builder.Property(hr => hr.Dia).IsRequired();
            builder.Property(hr => hr.MesId).IsRequired();
            builder.Property(hr => hr.Ano).IsRequired();

            builder.HasOne(hr => hr.Mes).WithMany(hr => hr.HistoricoRecursos).HasForeignKey(hr => hr.MesId);

        }
    }
}
