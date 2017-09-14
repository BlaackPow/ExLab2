using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExercicioSem4.Startup))]
namespace ExercicioSem4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
