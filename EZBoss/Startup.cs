using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EZBoss.Startup))]
namespace EZBoss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
