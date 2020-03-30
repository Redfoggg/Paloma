using Aliquota.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aliquota.Domain.Mapas
{
    public class MapaDeUsuario : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .ToTable("Usuario");
            builder
                .Property(u => u.Id)
                .HasColumnName("Id");

            builder
                .Property(u => u.Cpf)
                .HasColumnName("Cpf")
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder
                .Property(u => u.Senha)
                .HasColumnName("Senha")
                .HasColumnType("varchar(255)")
                .IsRequired();

        }
    }
}
