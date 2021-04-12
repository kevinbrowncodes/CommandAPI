using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandAPI.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CommandAPI
{
    public class Startup
    {
        public IConfiguration Configuration {get;}
        public Startup(IConfiguration configuration){
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // where "services" are registered (Jackson 100)
        // think of service as both an interface and an implementation of it (Jackson 100)
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CommandContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("PostgreSqlConnection")));
            
            services.AddControllers();

            services.AddScoped<ICommandAPIRepo, MockCommandAPIRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
