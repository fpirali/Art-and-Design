using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Art_and_Design.Startup))]
namespace Art_and_Design
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
