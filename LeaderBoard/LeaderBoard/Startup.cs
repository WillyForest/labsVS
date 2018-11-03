using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeaderBoard.Startup))]
namespace LeaderBoard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
