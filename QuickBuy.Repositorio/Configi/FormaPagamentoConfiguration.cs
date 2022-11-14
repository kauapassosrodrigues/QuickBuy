using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Configi
{

    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);
            builder
                 .Property(p => p.Nome)
                 .IsRequired()
                 .HasMaxLength(100);
            builder
                 .Property(p => p.Descricao)
                 .IsRequired()
                 .HasMaxLength(100);
                 
        }
    }
}
