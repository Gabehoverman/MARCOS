using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Marcos.Startup))]
namespace Marcos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
