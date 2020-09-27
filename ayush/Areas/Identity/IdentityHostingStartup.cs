using ayush.Data;
using ayush.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ayush.Areas.Identity.IdentityHostingStartup))]
namespace ayush.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<ayushContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ayushContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ayushContext>();

                services.AddMvc().AddRazorRuntimeCompilation();

                services.AddTransient(typeof(UserService));

                services.AddTransient(typeof(GraphService));

                services.AddTransient<IEmailSender, MessageService>();

                services.AddTransient(typeof(SmsService));

                services.AddTransient(typeof(SalesService));

                services.AddTransient(typeof(CareerService));

                services.AddTransient(typeof(PassiveCareerService));
            });
        }
    }
}