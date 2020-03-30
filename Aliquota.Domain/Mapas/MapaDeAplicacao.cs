using Aliquota.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aliquota.Domain.Mapas
{
    public class MapaDeAplicacao : IEntityTypeConfiguration<Aplicacao>
    {
        public void Configure(EntityTypeBuilder<Aplicacao> builder)
        {
            builder
                .ToTable("Aplicacao");
            
            builder
                .Property(a => a.Id)
                .HasColumnName("Id");

            builder
                .Property(a => a.Valor)
                .HasColumnName("Cpf")
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder
                .Property(a => a.Sigla)
                .HasColumnName("Sigla")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(a => a.DataDeAplicacao)
                .HasColumnName("DataDeAplicacao")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");

            builder
                .Property(a => a.UsuarioId)
                .HasColumnName("UsuarioId")
                .IsRequired();

        }
    }
}
