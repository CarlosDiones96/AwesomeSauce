using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace LoggerConfiguration
{
    public class Startup
    {
        private readonly ILoggerFactory loggerFactory;

        public Startup(ILoggerFactory loggerFactory)
        {
            this.loggerFactory = loggerFactory;
            var constructorLogger = loggerFactory.CreateLogger("Startup.ctor");
            constructorLogger.LogInformation("Logging from constructor!");
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var configureLogger = loggerFactory.CreateLogger("Startup.Configure");
            configureLogger.LogInformation("Logging from Configure!");
            app.Run(async (context) =>
            {
                var logger = loggerFactory.CreateLogger("Startup.Configure.Run");
                configureLogger.LogInformation("Logging from app.Run!");
                await context.Response.WriteAsync("Hello world");
            });
        }
    }
}
