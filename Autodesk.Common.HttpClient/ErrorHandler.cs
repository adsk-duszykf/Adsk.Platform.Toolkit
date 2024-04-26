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
            var message = await result.Content.ReadAsStringAsync(cancellationToken);

            if (string.IsNullOrEmpty(message))
            {
                message = ex.Message;
            }

            throw new HttpRequestException(ex.HttpRequestError, message);

        }

        return result;
    }
}
