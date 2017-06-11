using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JerriePelser.Startup))]
namespace JerriePelser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
