using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dohoangthuong_lab2_3.Startup))]
namespace dohoangthuong_lab2_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
