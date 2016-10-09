using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Thu_Vien_MVC.Startup))]
namespace Thu_Vien_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
