using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Water_Company.Startup))]
namespace MVC_Water_Company
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
