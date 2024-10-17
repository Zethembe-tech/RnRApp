using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReactAPI.Startup))]
namespace ReactAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
