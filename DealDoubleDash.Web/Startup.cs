using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DealDoubleDash.Web.Startup))]
namespace DealDoubleDash.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
