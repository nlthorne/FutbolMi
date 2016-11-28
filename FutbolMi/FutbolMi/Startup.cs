using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FutbolMi.Startup))]
namespace FutbolMi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
