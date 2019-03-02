using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bulgaria_at_the_Olympics.Startup))]
namespace Bulgaria_at_the_Olympics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
