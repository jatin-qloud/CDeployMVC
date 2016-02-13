using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CDeployMVC.Startup))]
namespace CDeployMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
