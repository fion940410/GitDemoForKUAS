using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eSalex3.Startup))]
namespace eSalex3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
