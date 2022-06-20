using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(marketPos.Startup))]
namespace marketPos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
