using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Thesis_Project_Management.Startup))]
namespace Thesis_Project_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
