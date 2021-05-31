using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoysToys.Startup))]
namespace BoysToys
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
