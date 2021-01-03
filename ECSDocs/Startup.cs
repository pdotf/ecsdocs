using Blazored.Modal;
using ECSDocs.Areas.Identity;
using EcsDataManager.Data;
using MatBlazor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Net.Http;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using EcsDataManager.Entities;
using EcsDataManager.EFContracts;
using EcsDataManager.EFConcrete;

namespace ECSDocs
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString("DefaultConnection")));




            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services
                  .AddBlazorise(options =>
                  {
                      options.ChangeTextOnKeyPress = true; // optional
                  })
                  .AddBootstrapProviders()
                  .AddFontAwesomeIcons();

            // other services



            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddBlazoredModal();
            services.AddMatBlazor();


            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddDatabaseDeveloperPageExceptionFilter();
            //services.AddSingleton<WeatherForecastService>();
            services.AddScoped<ICustomerUrlManager<CustomerUrl>, VpnCustomerManager>();
            services.AddScoped<ICRUDManager<IntranetCustomers>, IntranetCustomerManager>();
            services.AddScoped<ICRUDManager<ApnCustomers>, ApnCustomerManager>();
            services.AddScoped<ICRUDManager<VpnCustomers>, VpnCustomerManager>();
            services.AddScoped<ICRUDManager<DeviceList>, VpnDeviceManager>();
            services.AddScoped<IDeviceManager<DeviceList>, VpnDeviceManager>();
            services.AddScoped<IUpdateComment<ApnCustomers>, ApnCustomerManager>();
            services.AddScoped<IUpdateComment<IntranetCustomers>, IntranetCustomerManager>();
            services.AddScoped<IUpdateComment<VpnCustomers>, VpnCustomerManager>();

            //Register dapper in scope  
            //services.AddScoped<IDapperManager, DapperManager>();


            // Server Side Blazor doesn't register HttpClient by default
            if (!services.Any(x => x.ServiceType == typeof(HttpClient)))
            {
                // Setup HttpClient for server side in a client side compatible fashion
                services.AddScoped<HttpClient>(s =>
                {
                    // Creating the URI helper needs to wait until the JS Runtime is initialized, so defer it.
                    var uriHelper = s.GetRequiredService<NavigationManager>();
                    return new HttpClient
                    {
                        BaseAddress = new Uri(uriHelper.BaseUri)
                    };
                });
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //InitializeDatabase(app);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();


            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.ApplicationServices
                 .UseBootstrapProviders()
                 .UseFontAwesomeIcons();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
        //private void InitializeDatabase(IApplicationBuilder app)
        //{
        //    using (var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
        //    {
        //        scope.ServiceProvider.GetRequiredService<ApplicationDbContext>().Database.Migrate();

        //    }
        //}
    }
}
