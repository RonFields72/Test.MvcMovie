using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test.MvcMovie.Startup))]
namespace Test.MvcMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
