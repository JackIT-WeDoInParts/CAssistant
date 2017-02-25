using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CAssistant.Web.Startup))]
namespace CAssistant.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
