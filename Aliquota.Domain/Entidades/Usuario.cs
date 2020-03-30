using System;
using System.Collections.Generic;
using System.Text;

namespace Aliquota.Domain.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public float Cpf { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Aplicacao> Aplicacoes { get; set; }
    }
}
