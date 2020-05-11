using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Control_inventario.Startup))]
namespace Control_inventario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
