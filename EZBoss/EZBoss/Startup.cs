using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeAHost.Startup))]
namespace BeAHost
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
