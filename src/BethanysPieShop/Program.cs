using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace BethanysPieShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseApplicationInsights()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                  .ConfigureAppConfiguration((hostingContext, config) =>
                  {
                      var env = hostingContext.HostingEnvironment;
                      config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                            .AddJsonFile($"appsettings.Local.json", optional: true, reloadOnChange: true)
                            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                      config.AddEnvironmentVariables();
                  })
                // .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
