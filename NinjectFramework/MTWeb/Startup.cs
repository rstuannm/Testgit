using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MTWeb.Startup))]
namespace MTWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
