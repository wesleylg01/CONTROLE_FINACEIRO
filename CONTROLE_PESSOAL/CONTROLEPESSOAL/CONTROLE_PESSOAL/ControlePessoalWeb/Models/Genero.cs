using System;
using System.Collections.Generic;

namespace ControlePessoalWeb.Models
{
    public partial class Genero
    {
        public Genero()
        {
            Livro = new HashSet<Livro>();
        }

        public int Idgenero { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Livro> Livro { get; set; }
    }
}
