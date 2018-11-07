using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TeeScoreService.Startup))]

namespace TeeScoreService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}