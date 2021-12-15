using System;
using GameSureWebApp.Areas.Identity.Data;
//using GameSureWebApp.Areas.Identity.Data;
using GameSureWebApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GameSureWebApp.Areas.Identity.IdentityHostingStartup))]
namespace GameSureWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GameSureDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GameSureDBContextConnection")));

                services.AddDefaultIdentity<GameSureWebAppUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<GameSureDBContext>();
            });
        }
    }
}