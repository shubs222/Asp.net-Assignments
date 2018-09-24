using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_24th_Sep2018.Startup))]
namespace _24th_Sep2018
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
