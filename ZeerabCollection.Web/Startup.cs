using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZeerabCollection.Web.Startup))]
namespace ZeerabCollection.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
