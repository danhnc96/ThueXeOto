using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLThueXeOto.Startup))]
namespace QLThueXeOto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
