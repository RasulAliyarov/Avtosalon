using Avtosolon.Data;
using Avtosolon.Data.Interface;
using Avtosolon.Data.Models;
using Avtosolon.Data.Models.Interface;
using Avtosolon.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Avtosolon
{
    public class Startup
    {
        private IConfigurationRoot _conf;
        public Startup(IHostingEnvironment env)
        {
            _conf = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DBContent>(option => option.UseSqlServer(_conf.GetConnectionString("DefaultConnection")));
            services.AddTransient<IInfoCar, CarRepository>();
            services.AddTransient<ICategories, CategoryRepository>();
            services.AddTransient<IZakaz, ZakazRepositoriy>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => Korzina.Sessiyi(sp));
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name:"Filter",  template: "Cars/{action}/{category?}", defaults: new { Controllers = "Cars", action = "List" });
            });


            using (var scope = app.ApplicationServices.CreateScope())
            {
                DBContent content = scope.ServiceProvider.GetRequiredService<DBContent>();
                Objects.Initial(content);
            }
            
        }
    }
}
