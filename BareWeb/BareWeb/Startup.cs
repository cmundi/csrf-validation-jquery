using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BareWeb.Startup))]
namespace BareWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
