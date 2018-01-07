using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using WebASCATUR.Data;
using WebASCATUR.Data.Interfaces;
using WebASCATUR.Configuration;
using WebASCATUR.Data.Repositories;

namespace WebASCATUR
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
            .AddEnvironmentVariables();
            _currentEnv = builder.Build(); ;

            Configuration = configuration;
        }

        //public IConfiguration Configuration { get; }
        private readonly IConfigurationRoot _currentEnv;
        public IConfiguration Configuration { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<ApplicationConfigurations>(
            Configuration.GetSection("ApplicationConfigurations"));

            services.AddTransient<IServicioRepository, ServicioRepository>();
            services.AddTransient<IOpinionRepository, OpinionRepository>();
            services.AddTransient<IEventoRepository, EventoRepository>();
            services.AddTransient<IProductoRepository, ProductoRepository>();
            services.AddTransient<IOfertaRepository, OfertaRepository>();

            services.AddMvc();
            //var connection = @"Server=MANUEL\SQLEXPRESS;Database=AdmWebASCATUR_Default_v1;User Id=Emilio;Password=Ema2Vargas$;";
            var connection = @"Server=sql7003.site4now.net;Database=DB_A2B9BB_AdmWebASCATUR; User Id=DB_A2B9BB_AdmWebASCATUR_admin;Password=Ema2Vargas";
            services.AddDbContext<AdmWebASCATUR_Default_v1Context>(options => options.UseSqlServer(connection));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Default}/{action=Index}/{id?}");
            });
        }
    }
}
