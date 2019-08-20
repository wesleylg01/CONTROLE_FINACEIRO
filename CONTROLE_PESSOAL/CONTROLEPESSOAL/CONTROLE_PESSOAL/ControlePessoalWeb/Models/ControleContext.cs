using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ControlePessoalWeb.Models
{
    public class ControleContext : DbContext
    {
        public ControleContext() : base ("DefaultConnection")
        {
                
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}