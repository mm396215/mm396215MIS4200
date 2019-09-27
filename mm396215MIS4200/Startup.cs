using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mm396215MIS4200.Startup))]
namespace mm396215MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
