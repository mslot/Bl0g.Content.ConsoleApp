using Bl0g.Content.Workers.Interfaces;
using Bl0g.LogSink.Interfaces;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Bl0g.Content.ConsoleApp.Services
{
    public class ImportFilesService : IHostedService
    {
        private readonly IHostApplicationLifetime _hostApplicationLifetime;
        private readonly IImportFilesWorker _importFilesWorker;
        private readonly ILogSink _logger;

        public ImportFilesService(
            IHostApplicationLifetime hostApplicationLifetime,
            IImportFilesWorker importFilesWorker,
            ILogSink logger)
        {
            _hostApplicationLifetime = hostApplicationLifetime;
            _importFilesWorker = importFilesWorker;
            _logger = logger;
        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation<ImportFilesService>(nameof(ImportFilesService), nameof(StartAsync), Areas.START_OF_METHOD);
            try
            {
                await _importFilesWorker.Sync();
            }
            catch (Exception exception) //This needs to be more specific
            {
                _logger.LogError<ImportFilesService>(nameof(ImportFilesService), nameof(StartAsync), Areas.CATCH, exception);
                Environment.ExitCode = -1;
                
                /*
                 * No rethrow here because we need to have the correct exit code.
                 * For now I dont know how to do this when rethrowing.
                 */
            }
            finally
            {
                _hostApplicationLifetime.StopApplication();
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation<ImportFilesService>(nameof(ImportFilesService), nameof(StopAsync), Areas.APPLICATION_STOP);
            return Task.CompletedTask;
        }
    }
}
