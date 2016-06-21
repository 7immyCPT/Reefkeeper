using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reefkeeper.Startup))]
namespace Reefkeeper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.MapSignalR();
        }
    }
}
