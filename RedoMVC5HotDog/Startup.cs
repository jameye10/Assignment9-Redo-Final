using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedoMVC5HotDog.Startup))]
namespace RedoMVC5HotDog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
