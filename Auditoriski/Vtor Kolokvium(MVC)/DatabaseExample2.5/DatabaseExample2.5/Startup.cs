using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseExample2._5.Startup))]
namespace DatabaseExample2._5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
