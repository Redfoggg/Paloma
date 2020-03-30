using Aliquota.Domain.Entidades;
using Aliquota.Domain.Mapas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aliquota.Domain.Dados
{
    public class AliquotaContext : DbContext
    {
        public DbSet<Aplicacao> Aplicacoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Aliquota;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapaDeUsuario());
            modelBuilder.ApplyConfiguration(new MapaDeAplicacao());
        }

    }
}
