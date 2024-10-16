// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.CostManagement.V1.Projects.Item.WorkflowConditions.Reorder.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.WorkflowConditions.Reorder
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\workflow-conditions\:reorder
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WorkflowConditionsReorderRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.workflowConditions.Reorder.item collection</summary>
        /// <param name="position">The associated module.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.WorkflowConditions.Reorder.Item.WithAssociationTypeItemRequestBuilder"/></returns>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.WorkflowConditions.Reorder.Item.WithAssociationTypeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("associationType", position);
                return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.WorkflowConditions.Reorder.Item.WithAssociationTypeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.WorkflowConditions.Reorder.WorkflowConditionsReorderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowConditionsReorderRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/workflow-conditions/:reorder", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.WorkflowConditions.Reorder.WorkflowConditionsReorderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowConditionsReorderRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/workflow-conditions/:reorder", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
