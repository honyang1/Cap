using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cap_Layer.Startup))]
namespace Cap_Layer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
