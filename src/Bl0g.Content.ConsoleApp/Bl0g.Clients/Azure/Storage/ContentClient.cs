using Bl0g.Clients.Core.Interfaces;
using Bl0g.Clients.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bl0g.Clients.Azure.Storage
{
    public class ContentClient : IDiscoverableClient
    {
        Task<IEnumerable<IContentFile>> IDiscoverableClient.ListFiles(string path)
        {
            throw new NotImplementedException();
        }
    }
}
