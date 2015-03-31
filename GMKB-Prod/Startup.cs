using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GMKB_Prod.Startup))]
namespace GMKB_Prod
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
