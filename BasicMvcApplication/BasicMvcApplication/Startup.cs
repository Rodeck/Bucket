using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicMvcApplication.Startup))]
namespace BasicMvcApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
