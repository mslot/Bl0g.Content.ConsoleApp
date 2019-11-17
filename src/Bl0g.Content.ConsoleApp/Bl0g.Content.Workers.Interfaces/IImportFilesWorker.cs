using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bl0g.Content.Workers.Interfaces
{
    public interface IImportFilesWorker : IWorker
    {
        Task Sync();
    }
}
