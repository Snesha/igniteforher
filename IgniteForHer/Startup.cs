using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IgniteForHer.Startup))]
namespace IgniteForHer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
