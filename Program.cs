using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Timers;

namespace WebMonitoring
{
    public class Program
    {
        private static Timer ExportDanych { get; set; }

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
