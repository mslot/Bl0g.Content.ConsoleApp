using Bl0g.Clients.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bl0g.Clients.Interfaces
{
    public interface IDiscoverableClient
    {
        Task<IEnumerable<IContentFile>> ListFiles(string path);
    }
}
