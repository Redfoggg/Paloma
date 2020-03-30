using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Aliquota.Domain.Entidades
{
    public class Aplicacao
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public double Valor { get; set; }
        public DateTime DataDeAplicacao { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

    }
}
