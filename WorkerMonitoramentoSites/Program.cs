using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using WorkerMonitoramentoSites.Configuration;
using WorkerMonitoramentoSites.Data;

namespace WorkerMonitoramentoSites
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    var parametrosExecucao = new ParametrosExecucao();
                    new ConfigureFromConfigurationOptions<ParametrosExecucao>(
                        hostContext.Configuration
                            .GetSection("WorkerConfigurations"))
                            .Configure(parametrosExecucao);

                    services.AddSingleton<ParametrosExecucao>(parametrosExecucao);
                    services.AddSingleton<MonitoramentoRepository>();
                    services.AddHostedService<Worker>();
                });
    }
}