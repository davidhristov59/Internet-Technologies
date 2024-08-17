using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseExample2.Startup))]
namespace DatabaseExample2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
