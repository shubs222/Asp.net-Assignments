using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A_22nd_Sep2018.Startup))]
namespace A_22nd_Sep2018
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
