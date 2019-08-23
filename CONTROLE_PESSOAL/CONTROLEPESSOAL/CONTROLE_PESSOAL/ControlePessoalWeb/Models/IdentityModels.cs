using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ControlePessoalWeb.Models
{
    // É possível adicionar dados do perfil do usuário adicionando mais propriedades na sua classe ApplicationUser, visite https://go.microsoft.com/fwlink/?LinkID=317594 para obter mais informações.
    public class ApplicationUser : IdentityUser
    {
        public string   Nome        { get; set; }
        public DateTime DataNasc    { get; set; }
        public int      EstadoCivil { get; set; }
        public string   Telefone    { get; set; }
        public string   Celular     { get; set; }
        public string   Endereco    { get; set; }
        public string   Bairro      { get; set; }
        public string   Numero      { get; set; }
        public string   Cidade      { get; set; }
        public string   Uf          { get; set; }
        public string   Complmento  { get; set; }
        public string   Cep         { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Observe que o authenticationType deve corresponder àquele definido em CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Adicionar declarações de usuário personalizado aqui
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}