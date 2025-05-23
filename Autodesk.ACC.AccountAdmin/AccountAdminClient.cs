using Autodesk.Common.HttpClientLibrary; // For HttpClientFactory
using Microsoft.Kiota.Abstractions; // For IRequestAdapter
using System;
using System.Net.Http;
using System.Threading.Tasks;

// Namespace should align with the project structure
namespace Autodesk.ACC.AccountAdmin
{
    /// <summary>
    /// A client for interacting with the Autodesk ACC Account Admin service.
    /// This provides a more convenient way to initialize and access the underlying generated API client.
    /// </summary>
    public class AccountAdminClient
    {
        /// <summary>
        /// Gets the underlying Kiota-generated client for the Account Admin API.
        /// </summary>
        public BaseAccountAdminClient Api { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAdminClient"/> class.
        /// </summary>
        /// <param name="getAccessToken">A function that returns the OAuth2 access token.</param>
        /// <param name="httpClient">Optional: An HttpClient instance to use for requests. If null, a default one will be created.</param>
        public AccountAdminClient(Func<Task<string>> getAccessToken, HttpClient? httpClient = null)
        {
            if (getAccessToken == null)
            {
                throw new ArgumentNullException(nameof(getAccessToken));
            }

            IRequestAdapter adapter = Autodesk.Common.HttpClientLibrary.HttpClientFactory.CreateAdapter(getAccessToken, httpClient);
            this.Api = new BaseAccountAdminClient(adapter);
        }
    }
}
