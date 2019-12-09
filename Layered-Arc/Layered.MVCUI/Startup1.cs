using System;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Layered.MVCUI.Startup1))]

namespace Layered.MVCUI
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("ProjectContext");
            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}
