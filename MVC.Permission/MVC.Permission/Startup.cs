using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.Permission.Startup))]
namespace MVC.Permission
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
