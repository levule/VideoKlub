using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoKlub.Startup))]
namespace VideoKlub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
