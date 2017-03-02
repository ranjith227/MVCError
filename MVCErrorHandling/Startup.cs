using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCErrorHandling.Startup))]
namespace MVCErrorHandling
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
