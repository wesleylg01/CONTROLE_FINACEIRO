using System;
using System.Collections.Generic;

namespace ControlePessoalWeb.Models
{
    public partial class Leitura
    {
        public int Idmeta { get; set; }
        public int? Idpessoa { get; set; }
        public int? Idlivro { get; set; }
        public TimeSpan? Tempoleitura { get; set; }
        public int? Avaliacao { get; set; }
        public string Descavaliacao { get; set; }

        public virtual Livro IdlivroNavigation { get; set; }
    }
}
