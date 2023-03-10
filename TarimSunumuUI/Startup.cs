using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFrameworkRepository;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TarimSunumuUI
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
            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<ITeamService, TeamManager>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IImageService, ImageManager>();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<IAboutService, AboutManager>();

            services.AddScoped<IServiceDAL, EfServiceRepository>();
            services.AddScoped<ITeamDAL, EfTeamRepository>();
            services.AddScoped<IAnnouncementDAL, EfAnnouncementRepository>();
            services.AddScoped<IImageDAL, EfImageRepository>();
            services.AddScoped<IAddressDal, EfAddressRepository>();
            services.AddScoped<IContactDAL, EfContactRepository>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaRepository>();
            services.AddScoped<IAboutDal, EfAboutRepository>();
 
            services.AddDbContext<TarimContext>();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

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
