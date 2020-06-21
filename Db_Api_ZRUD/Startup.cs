using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Db_Api_CRUD.Startup))]
namespace Db_Api_CRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
