using System.Net;

namespace Autodesk.Common.HttpClientLibrary;

/// <summary>
/// Error handler for the HttpClient that will throw an exception if the response is not successful, and will include the response body in the exception message.
/// </summary>
public class ErrorHandler : DelegatingHandler
{
    public ErrorHandler()
    {
        InnerHandler = new HttpClientHandler();
    }
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var result = await base.SendAsync(request, cancellationToken);

        try
        {
            result.EnsureSuccessStatusCode();

        }
        catch (HttpRequestException ex)
        {
            if (ShouldRetry(ex.StatusCode) || IsRedirect(ex.StatusCode))
            {
                return result;
            }

            var message = await result.Content.ReadAsStringAsync(cancellationToken);

            if (string.IsNullOrEmpty(message))
            {
                message = ex.Message;
            }

            throw new HttpRequestException(ex.HttpRequestError, message);

        }

        return result;
    }

    private static bool ShouldRetry(HttpStatusCode? statusCode)
    {
        return statusCode switch
        {
            HttpStatusCode.ServiceUnavailable => true,
            HttpStatusCode.GatewayTimeout => true,
            (HttpStatusCode)429 => true,
            _ => false
        };
    }

    private static bool IsRedirect(HttpStatusCode? statusCode)
    {
        return statusCode switch
        {
            HttpStatusCode.MovedPermanently => true,
            HttpStatusCode.Found => true,
            HttpStatusCode.SeeOther => true,
            HttpStatusCode.TemporaryRedirect => true,
            (HttpStatusCode)308 => true,
            _ => false
        };
    }
}
