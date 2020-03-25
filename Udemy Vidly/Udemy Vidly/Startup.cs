using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Udemy_Vidly.Startup))]
namespace Udemy_Vidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
