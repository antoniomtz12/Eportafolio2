using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eportafolio2.Startup))]
namespace Eportafolio2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
