using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace LoggerGrouping
{
    public class Startup
    {
        private readonly ILogger logger;

        public Startup(ILogger<Startup> logger)
        {
            this.logger = logger;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Run(async (context) =>
           {
               using (logger.BeginScope("This is an awesome group"))
               {
                   logger.LogInformation("Log entry 1");
                   logger.LogWarning("Log entry 2");
                   logger.LogError("Log entry 3");
               }

               await context.Response.WriteAsync("Hello world");
           });
        }
    }
}
