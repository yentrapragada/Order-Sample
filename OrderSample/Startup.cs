using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrderSample.Startup))]
namespace OrderSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
