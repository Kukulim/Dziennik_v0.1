using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dziennik_v0._1.Startup))]
namespace Dziennik_v0._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
