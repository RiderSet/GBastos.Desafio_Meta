using GBastos.Desafio_Meta.InfraEstructure.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace GBastos.Desafio_Meta.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);
            // CreateHostBuilder(args).Build().Run();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<Contexto>();
                    DbInitializer.Initialize(context);
                }
                catch(Exception ex)
                {
                    var logger = services.GetRequiredService <ILogger<Program>>();
                    logger.LogError(ex, "Um erro ocorreu no método Seeding do contexto.");
                }
            }
            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>().Build();
    }
}