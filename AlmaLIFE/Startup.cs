using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlmaLIFE.Startup))]
namespace AlmaLIFE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
