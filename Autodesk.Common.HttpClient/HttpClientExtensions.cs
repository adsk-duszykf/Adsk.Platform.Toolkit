using Microsoft.Extensions.DependencyInjection;

namespace Autodesk.Common.HttpClientLibrary;


public static class HttpClientExtensions
{
    /// <summary>
    /// Adds the Kiota handlers to the service collection.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/> to add the services to</param>
    /// <returns><see cref="IServiceCollection"/> as per convention</returns>
    public static IServiceCollection AddAdskToolkitHttpClient(this IServiceCollection services, string httpClientName)
    {
        services.AddToolkitHandlers();
        services.AddHttpClient(httpClientName).AttachToolkitHandlers();
        return services;
    }

    /// <summary>
    /// Adds the Kiota handlers to the service collection.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/> to add the services to</param>
    /// <returns><see cref="IServiceCollection"/> as per convention</returns>
    internal static IServiceCollection AddToolkitHandlers(this IServiceCollection services)
    {
        var toolkitHandlers = HttpClientFactory.GetDefaultHandlerTypes();

        // And register them in the DI container
        foreach (var handler in toolkitHandlers)
        {
            services.AddTransient(handler);
        }

        return services;
    }
    /// <summary>
    /// Adds the Kiota handlers to the http client builder.
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    /// <remarks>
    /// The order in which the handlers are added is important, as it defines the order in which they will be executed.
    /// </remarks>
    internal static IHttpClientBuilder AttachToolkitHandlers(this IHttpClientBuilder builder)
    {
        var toolkitHandlers = HttpClientFactory.GetDefaultHandlerTypes();

        // And attach them to the http client builder
        foreach (var handler in toolkitHandlers)
        {
            builder.AddHttpMessageHandler((sp) => (DelegatingHandler)sp.GetRequiredService(handler));
        }

        return builder;
    }
}