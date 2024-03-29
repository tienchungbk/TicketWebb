﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TicketWeb.Areas.Identity.Data;
using TicketWeb.Data;

[assembly: HostingStartup(typeof(TicketWeb.Areas.Identity.IdentityHostingStartup))]
namespace TicketWeb.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TicketWebContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TicketWebContextConnection")));

                services.AddDefaultIdentity<TicketWebUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<TicketWebContext>();
            });
        }
    }
}