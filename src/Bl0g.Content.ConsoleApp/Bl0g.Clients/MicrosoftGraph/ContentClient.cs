using Bl0g.Clients.Core.Interfaces;
using Bl0g.Clients.Interfaces;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bl0g.Clients.MicrosoftGraph
{
    public class ContentClient : IDiscoverableClient
    {
        private readonly IConfidentialClientApplication _clientApplication;
        private readonly string[] _scopes = new string[] { "https://graph.microsoft.com/.default" };

        public ContentClient(IConfidentialClientApplication clientApplication)
        {
            _clientApplication = clientApplication;

        }
        public async Task<IEnumerable<IContentFile>> ListFiles(string path)
        {
            var files = new LinkedList<IContentFile>();
            string accessToken = String.Empty;

            AuthenticationResult result = await _clientApplication
                .AcquireTokenForClient(_scopes)
                .ExecuteAsync();

            accessToken = result.AccessToken;

            return files;
        }
    }
}
