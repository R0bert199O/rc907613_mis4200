using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rc907613_mis4200.Startup))]
namespace rc907613_mis4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
