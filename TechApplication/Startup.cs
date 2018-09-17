using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechApplication.Startup))]
namespace TechApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
