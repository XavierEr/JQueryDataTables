using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JQueryDataTables.Startup))]
namespace JQueryDataTables
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
