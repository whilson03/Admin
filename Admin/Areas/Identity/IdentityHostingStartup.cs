using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Admin.Areas.Identity.IdentityHostingStartup))]
namespace Admin.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}