using AutoMapper;
using ayush.Data;
using ayush.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ayush
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddTransient(typeof(ISmsService), typeof(SmsService));
            services.AddDbContext<ayushContext>(options => options.UseSqlServer("ayushContextConnection"));

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            });


            services.AddAuthentication()
                .AddGoogle(option =>
                {
                    option.ClientId = "254652166385-420o7aqdt6jls5mpv5t0a1nhqgoh88hk.apps.googleusercontent.com";
                    option.ClientSecret = "GF_yYNOgmUdeh-vZgPd67Zmc";
                    option.SignInScheme = IdentityConstants.ExternalScheme;
                });

            services.AddAuthentication()
                .AddFacebook(option =>
                {
                    option.ClientId = "2381709682122611";
                    option.ClientSecret = "a997b64bc7a25d9bc7ac89c934342062";
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy =>
                {
                    policy.RequireRole("Admin");
                });
                options.AddPolicy("Student", policy =>
              {
                  policy.RequireRole("Student");
              });

                options.AddPolicy("Counsellor", policy =>
                {
                    policy.RequireRole("Counsellor");
                });
                options.AddPolicy("School", policy =>
                {
                    policy.RequireRole("School");
                });

            });

            services.AddMvc()
            .AddRazorPagesOptions(options =>
            {
                options.Conventions.AuthorizeFolder("/Admin", "Admin");
                options.Conventions.AuthorizeFolder("/Student", "Student");
                options.Conventions.AuthorizeFolder("/Counsellor", "Counsellor");
                options.Conventions.AuthorizeFolder("/School", "School");
            });

            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");
            services.AddControllers();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ayushContext context)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            CreateRolesOnStartup.SeedData(userManager, roleManager, context);
            app.UseAuthorization();
            app.UseHttpsRedirection();
           


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
            //app.UseMvc();
        }
    }
}
