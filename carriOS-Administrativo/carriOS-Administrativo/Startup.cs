using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(carriOS_Administrativo.Startup))]
namespace carriOS_Administrativo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
