using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CENG396WWTTMS.Models;
using CENG396WWTTMS.Models.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace CENG396WWTTMS
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
            services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);
            services.AddRazorPages()
                .AddMvcOptions(options =>
                 {
                     options.MaxModelValidationErrors = 50;
                     options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(
                         _ => "This field is required.");
                 });

            //services.AddDistributedMemoryCache();
            // Add ASPNETCoreDemoDBContext services. 
            services.AddDbContext<CENG396_WWTTMSContext>(options => options.UseSqlServer(Configuration.GetConnectionString("EFCoreDBFirstDemoDatabase")));
            //services.AddDbContext<CENG396_WWTTMSContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDbContext<CENG396_WWTTMSContext>(options =>
            //    options.UseInMemoryDatabase()); 
            //services.AddSession(); 
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);//We set Time here 
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddAuthentication(options => { options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme; 
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme; 
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme; 
            }).AddCookie(); 
            services.AddMvc();
            

        }

        private void AddMvcOptions(Action<object> p)
        {
            throw new NotImplementedException();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) { app.UseDeveloperExceptionPage(); }
            else
            {
                app.UseExceptionHandler("/Error"); 
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts. 
                app.UseHsts(); 
            
            }
            app.UseSession(); 
            app.UseHttpsRedirection(); 
            app.UseStaticFiles(); 
            app.UseRouting(); 
            app.UseAuthorization(); 
            app.UseAuthentication(); 
            app.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });
        }
    }
}
