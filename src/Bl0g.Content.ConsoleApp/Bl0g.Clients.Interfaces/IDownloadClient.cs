using Bl0g.Clients.Core.Interfaces;
using System.Collections.Generic;

namespace Bl0g.Clients.Interfaces
{
    public interface IDownloadClient
    {
        IEnumerable<IContentFile> DownloadFiles();
    }
}
