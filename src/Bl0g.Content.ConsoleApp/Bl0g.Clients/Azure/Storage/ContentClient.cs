using Bl0g.Clients.Core.Interfaces;
using Bl0g.Clients.Interfaces;
using System;
using System.Collections.Generic;

namespace Bl0g.Clients.Azure.Storage
{
    public class ContentClient : IDownloadClient
    {
        public IEnumerable<IContentFile> DownloadFiles()
        {
            throw new NotImplementedException();
        }
    }
}
