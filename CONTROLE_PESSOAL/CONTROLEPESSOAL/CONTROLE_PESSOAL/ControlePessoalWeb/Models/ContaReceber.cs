using System;
using System.Collections.Generic;

namespace ControlePessoalWeb.Models
{
    public partial class ContaReceber
    {
        public int IdcontaReceber { get; set; }
        public int? Idpessoa { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? Vencimento { get; set; }
        public string Descricao { get; set; }
        public int? Formapagamento { get; set; }
        public int? Mesreferencia { get; set; }
        public int? Anoreferencia { get; set; }
        public bool? Parcelamento { get; set; }
        public int? Totalparcelas { get; set; }
        public int? Parcelasrecebidas { get; set; }
        public int? Parcelasreceber { get; set; }

        public virtual Pessoa IdpessoaNavigation { get; set; }
    }
}
