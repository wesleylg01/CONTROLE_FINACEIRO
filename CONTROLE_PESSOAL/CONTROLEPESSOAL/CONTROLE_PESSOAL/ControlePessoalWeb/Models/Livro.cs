using System;
using System.Collections.Generic;

namespace ControlePessoalWeb.Models
{
    public partial class Livro
    {
        public Livro()
        {
            Leitura = new HashSet<Leitura>();
        }

        public int Idlivro { get; set; }
        public int? Idgenero { get; set; }
        public int? Idautor { get; set; }
        public string Titulo { get; set; }
        public string Idioma { get; set; }
        public int? QtdPaginas { get; set; }

        public virtual Autor IdautorNavigation { get; set; }
        public virtual Genero IdgeneroNavigation { get; set; }
        public virtual ICollection<Leitura> Leitura { get; set; }
    }
}
