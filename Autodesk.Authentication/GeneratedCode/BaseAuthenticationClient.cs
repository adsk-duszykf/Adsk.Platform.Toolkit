// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.Authentication.Authentication;
using Autodesk.Authentication.WellKnown;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Autodesk.Authentication
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BaseAuthenticationClient : BaseRequestBuilder
    {
        /// <summary>The authentication property</summary>
        public global::Autodesk.Authentication.Authentication.AuthenticationRequestBuilder Authentication
        {
            get => new global::Autodesk.Authentication.Authentication.AuthenticationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The wellKnown property</summary>
        public global::Autodesk.Authentication.WellKnown.WellKnownRequestBuilder WellKnown
        {
            get => new global::Autodesk.Authentication.WellKnown.WellKnownRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.Authentication.BaseAuthenticationClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BaseAuthenticationClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
            {
                RequestAdapter.BaseUrl = "https://developer.api.autodesk.com";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}
#pragma warning restore CS0618
