using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventMS.Startup))]
namespace EventMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
