using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Iskra_Marks_App.Web.Startup))]
namespace Iskra_Marks_App.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
