using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodRecipies.Startup))]
namespace FoodRecipies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
