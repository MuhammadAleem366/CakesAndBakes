using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CakesAndBakes.Startup))]
namespace CakesAndBakes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
