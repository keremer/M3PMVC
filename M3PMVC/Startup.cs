using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(M3PMVC.Startup))]
namespace M3PMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
