using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hortkut.Web.Startup))]
namespace Hortkut.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
