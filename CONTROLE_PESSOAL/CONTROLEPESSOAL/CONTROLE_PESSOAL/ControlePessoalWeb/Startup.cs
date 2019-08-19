using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlePessoalWeb.Startup))]
namespace ControlePessoalWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
