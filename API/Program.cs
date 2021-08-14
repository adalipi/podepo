using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace API
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var log = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                log.Info("Starting the API");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                log.Error($"Stopped because of error:{ex}");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.SetMinimumLevel(LogLevel.Trace);
                }).UseNLog();
    }
}
