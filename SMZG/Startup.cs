using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMZG.Startup))]
namespace SMZG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
