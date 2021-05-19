using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApiSegura.Principal.Startup))]
namespace WebApiSegura.Principal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
