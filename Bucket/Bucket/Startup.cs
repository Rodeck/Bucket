using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bucket.Startup))]
namespace Bucket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
