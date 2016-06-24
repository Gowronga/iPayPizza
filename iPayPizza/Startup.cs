using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iPayPizza.Startup))]
namespace iPayPizza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
