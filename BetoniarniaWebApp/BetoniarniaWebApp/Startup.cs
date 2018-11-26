using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BetoniarniaWebApp.Startup))]
namespace BetoniarniaWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
