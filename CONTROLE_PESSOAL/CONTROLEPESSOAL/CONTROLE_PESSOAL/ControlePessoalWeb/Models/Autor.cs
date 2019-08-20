using System;
using System.Collections.Generic;

namespace ControlePessoalWeb.Models
{
    public partial class Autor
    {
        public Autor()
        {
            Livro = new HashSet<Livro>();
        }

        public int Idautor { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Livro> Livro { get; set; }
    }
}
