
using Microsoft.Extensions.Diagnostics.HealthChecks;
using TinyHealthCheck;
using WorkerService.Services;

namespace WorkerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Worker>();
                    services.AddScoped<IFelineService, FelineService>();
                    services.AddBasicTinyHealthCheckWithUptime(c =>
                    {
                        c.Port = 5001;
                        c.Hostname = "*";
                        c.UrlPath = "/healthcheck";
                        return c;
                    });
                })
                .Build();
            
            host.Run();
        }
    }
}