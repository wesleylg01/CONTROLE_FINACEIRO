using System;
using System.Collections.Generic;

namespace ControlePessoalWeb.Models
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            ContaPagar = new HashSet<ContaPagar>();
            ContaReceber = new HashSet<ContaReceber>();
            Meta = new HashSet<Meta>();
            Usuario = new HashSet<Usuario>();
        }

        public int Idpessoa { get; set; }
        public string Nome { get; set; }
        public DateTime? Datanasc { get; set; }
        public int? Estadocivil { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Complmento { get; set; }
        public string Cep { get; set; }

        public virtual ICollection<ContaPagar> ContaPagar { get; set; }
        public virtual ICollection<ContaReceber> ContaReceber { get; set; }
        public virtual ICollection<Meta> Meta { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
