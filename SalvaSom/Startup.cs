using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalvaSom.Startup))]
namespace SalvaSom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
