using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UET_EMS.Startup))]
namespace UET_EMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
