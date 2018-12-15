using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Data.SQLite;
using LIST.Data;
using Microsoft.EntityFrameworkCore;

namespace LIST
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<LeerlingContext>(options =>options.UseSqlServer(LIST.Classes.Engine.connectionstring()));
            services.AddDbContext<LOBContext>(options => options.UseSqlServer(LIST.Classes.Engine.connectionstring()));
            services.AddDbContext<DocentContext>(options => options.UseSqlServer(LIST.Classes.Engine.connectionstring()));
            services.AddDbContext<NewsContext>(options => options.UseSqlServer(LIST.Classes.Engine.connectionstring()));

            services.AddMvc();
            services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
            services.AddSession();

            services.Configure<IISOptions>(options =>
            {
                options.ForwardClientCertificate = false;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("");
                
            }

            app.UseSession();
            app.UseStaticFiles();
            app.UseMiddleware<LIST.Middlewares.AuthenticationMiddleware>();

           
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                name: "areas",
                template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            );
            });

        }
    }
}
