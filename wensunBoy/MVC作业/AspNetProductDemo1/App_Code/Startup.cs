using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNETProductdemo.Startup))]
namespace ASPNETProductdemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
