using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Agiles2017.Ahorcado.Web.Startup))]
namespace Agiles2017.Ahorcado.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
