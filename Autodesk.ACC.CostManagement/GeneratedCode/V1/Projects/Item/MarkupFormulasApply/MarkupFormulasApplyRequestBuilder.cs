// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.CostManagement.V1.Projects.Item.MarkupFormulasApply.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.MarkupFormulasApply
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\markup-formulas:apply
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MarkupFormulasApplyRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.markupFormulasApply.item collection</summary>
        /// <param name="position">The markup formula id.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.MarkupFormulasApply.Item.MarkupFormulasApplyItemRequestBuilder"/></returns>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.MarkupFormulasApply.Item.MarkupFormulasApplyItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.MarkupFormulasApply.Item.MarkupFormulasApplyItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.MarkupFormulasApply.MarkupFormulasApplyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MarkupFormulasApplyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/markup-formulas:apply", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.MarkupFormulasApply.MarkupFormulasApplyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MarkupFormulasApplyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/markup-formulas:apply", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
