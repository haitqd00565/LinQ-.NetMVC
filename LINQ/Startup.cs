using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LINQ.Startup))]
namespace LINQ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
