using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phono.Startup))]
namespace Phono
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
