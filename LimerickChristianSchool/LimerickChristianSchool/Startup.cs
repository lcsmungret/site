using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LimerickChristianSchool.Startup))]
namespace LimerickChristianSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
