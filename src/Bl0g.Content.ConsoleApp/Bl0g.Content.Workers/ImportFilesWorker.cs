using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bl0g.Content.Workers
{
    public class ImportFilesWorker : Interfaces.IImportFilesWorker
    {
        private readonly Jobs.Interfaces.IDownloadJob _downloadJob;
        private readonly Jobs.Interfaces.IUpSertJob _upsertJob;

        public ImportFilesWorker(
            Jobs.Interfaces.IDownloadJob downloadJob, 
            Jobs.Interfaces.IUpSertJob upsertJob)
        {
            _downloadJob = downloadJob;
            _upsertJob = upsertJob;

        }

        public async Task Sync()
        {
            throw new NotImplementedException();
        }
    }
}
