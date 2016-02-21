using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LimerickChristianCentre.Startup))]
namespace LimerickChristianCentre
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
