using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruckMessage.Core.Connection;
using TruckMessage.Core.DataAccess;
using TruckMessage.Core.Encrypter;
using TruckMessage.Core.Service.RequestContext;
using TruckMessage.Core.Service.UserHelper;

namespace TruckMessage {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();



            services.AddScoped<IEncrypter, Encrypter>();
            services.AddScoped<ConnectionStrings>();
            services.AddScoped<IUserHelper, UserHelper>();
            services.AddScoped<IRequestContextService, RequestContextService>();
            services.AddScoped<IDatabase, Database>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
