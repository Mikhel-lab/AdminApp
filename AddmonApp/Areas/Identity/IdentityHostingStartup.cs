using System;
using AddmonApp.Areas.Identity.Data;
using AddmonApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AddmonApp.Areas.Identity.IdentityHostingStartup))]
namespace AddmonApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AddmonAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AddmonAppContextConnection")));

                services.AddDefaultIdentity<AddmonAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AddmonAppContext>();
            });
        }
    }
}