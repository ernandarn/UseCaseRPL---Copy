using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UseCaseRPL.Startup))]
namespace UseCaseRPL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
