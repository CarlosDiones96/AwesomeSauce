using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BasicConfig
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("awesomeConfig.json");
            Configuration = builder.Build();

            foreach (var item in Configuration.AsEnumerable())
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.ReadKey();
        }

        public static IConfigurationRoot Configuration { get; set; }
    }
}
