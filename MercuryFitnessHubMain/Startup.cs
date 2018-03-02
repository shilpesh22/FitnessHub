using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MercuryFitnessHubMain.Startup))]
namespace MercuryFitnessHubMain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
