using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab6_ASPNET.Startup))]
namespace Lab6_ASPNET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
