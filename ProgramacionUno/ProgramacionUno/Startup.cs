using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProgramacionUno.Startup))]
namespace ProgramacionUno
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
