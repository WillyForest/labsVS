using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvclab4.Startup))]
namespace mvclab4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
