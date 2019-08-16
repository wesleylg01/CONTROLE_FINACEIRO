using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CONTROLE_PESSOAL.Startup))]
namespace CONTROLE_PESSOAL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
