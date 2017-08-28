using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubUserSearchMvc.Startup))]
namespace GitHubUserSearchMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
