using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvclab4v2.Startup))]
namespace mvclab4v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
