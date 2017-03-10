using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eSales2.Startup))]
namespace eSales2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
