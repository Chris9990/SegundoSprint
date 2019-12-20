using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gestion.Startup))]
namespace Gestion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
