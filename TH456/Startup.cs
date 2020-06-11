using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TH456.Startup))]
namespace TH456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
