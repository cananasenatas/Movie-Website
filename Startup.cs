using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieWebSite.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

using System.Globalization;

using MovieWebSite.Validators;
using FluentValidation.AspNetCore;
using FluentValidation;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace MovieWebSite
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
            services.AddSingleton(HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.BasicLatin, UnicodeRanges.Latin1Supplement, UnicodeRanges.LatinExtendedA }));
            services.AddRazorPages();
            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
                {
                    x.LoginPath = "/Log/Index/";
                });

            // services.AddControllersWithViews().AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<Startup>());


            services.AddControllers().AddFluentValidation(fv =>
            {
                fv.RegisterValidatorsFromAssemblyContaining<WebsiteValidator>();
            });

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            else
            {
                app.UseExceptionHandler("/Error");
                //  The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            ValidatorOptions.Global.LanguageManager.Enabled = false;

            ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("tr-TR");


            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}