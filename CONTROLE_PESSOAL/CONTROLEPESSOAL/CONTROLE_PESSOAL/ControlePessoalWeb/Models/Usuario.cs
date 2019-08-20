using System;
using System.Collections.Generic;

namespace ControlePessoalWeb.Models
{
    public partial class Usuario
    {
        public int Idusuario { get; set; }
        public int? CodUsuario { get; set; }
        public string Usuario1 { get; set; }
        public string Senha { get; set; }
        public int? Idpessoa { get; set; }

        public virtual Pessoa IdpessoaNavigation { get; set; }
    }
}
