using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(PriLalo.Web.Areas.Identity.IdentityHostingStartup))]
namespace PriLalo.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}