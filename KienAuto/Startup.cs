using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KienAuto.Startup))]
namespace KienAuto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
