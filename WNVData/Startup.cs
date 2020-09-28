using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WNVData.Startup))]
namespace WNVData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
