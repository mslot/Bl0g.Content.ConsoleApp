using Bl0g.Content.ConsoleApp.Mappers;
using Bl0g.Content.Jobs;
using Bl0g.Content.Jobs.Interfaces;
using Bl0g.Content.Workers;
using Bl0g.Content.Workers.Interfaces;
using Bl0g.LogSink;
using Bl0g.LogSink.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace Bl0g.Content.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await CreateHostBuilder(args)
                .Build().
                RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<Services.ImportFilesService>();
                services.AddSingleton<IUpSertJob, UpSertContentToDatabaseJob>();
                services.AddSingleton<IDownloadJob, DownloadFilesJob>();
                services.AddSingleton<IImportFilesWorker, ImportFilesWorker>();
                services.AddSingleton<ILogSink, SimpleLogSink>();
                services.AddSingleton<IEventIdMapper, ConsoleAppEventIdMapper>();
            });
    }
}
