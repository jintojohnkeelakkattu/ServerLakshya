using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using static AdminSolution.DataLayer.DBLayer;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace AdminSolution
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var config = new ConfigurationBuilder()
                        .SetBasePath(env.ContentRootPath)
                        .AddJsonFile("appsettings.json");
                        Configuration = config.Build();

        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddAutoMapper();
            services.AddMvc();
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddDbContext<DbLayerContext>(options =>
       options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("MyPolicy");

            app.UseMvc();
            // app.UseMvcWithDefaultRoute();
            app.UseMvc(route =>
            {
                route.MapRoute(
                name: "default",
                template: "{controller}/{action}/{id?}",
                defaults: new { controller = "Values", action = "Get" });
            });
        }
    }
}
