using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace StronglyTypedConfiguration
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("awesomeConfig.json");

            var awesomeOptions = new AwesomeOptions();
            builder.Build().Bind(awesomeOptions);

            Console.WriteLine($"Foo: {awesomeOptions.Foo}");
            Console.WriteLine($"Bar: {awesomeOptions.Bar}");
            Console.WriteLine($"Baz.Foo: {awesomeOptions.Baz.Foo}");

            Console.ReadKey();


        }
    }
}
