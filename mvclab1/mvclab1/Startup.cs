using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvclab1.Startup))]
namespace mvclab1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
