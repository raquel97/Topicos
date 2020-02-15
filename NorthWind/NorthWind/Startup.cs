using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthWind.Startup))]
namespace NorthWind
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
