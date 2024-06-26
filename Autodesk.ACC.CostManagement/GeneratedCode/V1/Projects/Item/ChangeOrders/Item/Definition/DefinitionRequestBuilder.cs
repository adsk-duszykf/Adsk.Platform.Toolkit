// <auto-generated/>
using Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.Definition.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.Definition {
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\change-orders\{changeOrder}\definition
    /// </summary>
    public class DefinitionRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.changeOrders.item.definition.item collection</summary>
        /// <param name="position">The form definition ID.</param>
        /// <returns>A <see cref="WithDefinitionItemRequestBuilder"/></returns>
        public WithDefinitionItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("definitionId", position);
                return new WithDefinitionItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="DefinitionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DefinitionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/change-orders/{changeOrder}/definition", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DefinitionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DefinitionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/change-orders/{changeOrder}/definition", rawUrl)
        {
        }
    }
}
