using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Viljaladu.Startup))]
namespace Viljaladu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
