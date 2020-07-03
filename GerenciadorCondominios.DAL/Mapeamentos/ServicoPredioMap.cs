﻿using System;
using System.Collections.Generic;
using System.Text;
using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class ServicoPredioMap : IEntityTypeConfiguration<ServicoPredio>
    {
        public void Configure(EntityTypeBuilder<ServicoPredio> builder)
        {
            builder.HasKey(SP => SP.ServicoPredioId);
            builder.Property(sp => sp.ServicoId).IsRequired();
            builder.Property(sp => sp.DataExecucao).IsRequired();


            builder.HasOne(sp => sp.Servico).WithMany(sp => sp.ServicoPredios).HasForeignKey(sp => sp.ServicoId);

        }
    }
}
