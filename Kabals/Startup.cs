using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kabals.Startup))]
namespace Kabals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
