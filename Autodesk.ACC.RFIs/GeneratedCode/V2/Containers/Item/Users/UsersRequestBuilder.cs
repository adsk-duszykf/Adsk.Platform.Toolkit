// <auto-generated/>
using Autodesk.ACC.RFIs.V2.Containers.Item.Users.Me;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.RFIs.V2.Containers.Item.Users {
    /// <summary>
    /// Builds and executes requests for operations under \v2\containers\{containerId}\users
    /// </summary>
    public class UsersRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The me property</summary>
        public MeRequestBuilder Me
        {
            get => new MeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/containers/{containerId}/users", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/containers/{containerId}/users", rawUrl)
        {
        }
    }
}
