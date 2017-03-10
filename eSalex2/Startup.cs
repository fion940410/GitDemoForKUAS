using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eSalex2.Startup))]
namespace eSalex2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
