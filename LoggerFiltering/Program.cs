using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace LoggerFiltering
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .ConfigureLogging(logging =>
                {
                    logging
                        .SetMinimumLevel(LogLevel.None)
                        .AddFilter("Default", LogLevel.Error)
                        .AddFilter<ConsoleLoggerProvider>("Program.Startup", LogLevel.Critical);
                })
                .Build()
                .Run();
        }
    }
}
