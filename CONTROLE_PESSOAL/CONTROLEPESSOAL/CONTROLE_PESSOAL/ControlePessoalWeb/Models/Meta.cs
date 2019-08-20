using System;
using System.Collections.Generic;

namespace ControlePessoalWeb.Models
{
    public partial class Meta
    {
        public int Idmeta { get; set; }
        public int? Idpessoa { get; set; }
        public int? Tipometa { get; set; }
        public string Nomemeta { get; set; }
        public string Descricao { get; set; }
        public DateTime? Prazo { get; set; }

        public virtual Pessoa IdpessoaNavigation { get; set; }
    }
}
