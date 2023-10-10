using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppMVC_CRUD_AngularJS.Startup))]
namespace AppMVC_CRUD_AngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
