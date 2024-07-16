using System.Collections.Concurrent;

namespace Autodesk.Common.HttpClientLibrary;

public class RateLimitingHandler(HttpMessageHandler innerHandler, int maxRequests, TimeSpan? timeWindow = null) : DelegatingHandler(innerHandler)
{
    private readonly ConcurrentDictionary<string, RateLimiter> _rateLimiters = new();
    private readonly int _maxRequests = maxRequests;
    private readonly TimeSpan? _timeWindows = timeWindow;

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (_maxRequests > 0)
        {
            var endpoint = GetEndpoint(request);
            var rateLimiter = _rateLimiters.GetOrAdd(endpoint, (_) => new RateLimiter(_maxRequests, _timeWindows));

            await rateLimiter.WaitForAvailabilityAsync();

        }

        return await base.SendAsync(request, cancellationToken);
    }

    private static string GetEndpoint(HttpRequestMessage request)
    {
        // Customize this method to identify endpoints uniquely based on your API structure
        return $"{request.Method}|{request.RequestUri?.GetLeftPart(UriPartial.Path) ?? ""}";
    }
}

public class RateLimiter
{
    private int _requestCount;
    private DateTime _resetTime;
    private readonly int _maxRequests;
    private readonly TimeSpan _timeWindow;
    private readonly SemaphoreSlim _semaphore;

    public RateLimiter(int maxRequests = 10, TimeSpan? timeWindow = null)
    {
        _maxRequests = maxRequests;
        _timeWindow = timeWindow ?? TimeSpan.FromMinutes(1);
        _resetTime = DateTime.UtcNow + _timeWindow;
        _semaphore = new SemaphoreSlim(1, 1);
    }

    public async Task WaitForAvailabilityAsync()
    {
        await _semaphore.WaitAsync();

        try
        {
            if (DateTime.UtcNow >= _resetTime)
            {
                _requestCount = 0;
                _resetTime = DateTime.UtcNow + _timeWindow;
            }

            if (_requestCount >= _maxRequests)
            {
                var delay = _resetTime - DateTime.UtcNow;
                if (delay > TimeSpan.Zero)
                {
                    await Task.Delay(delay);
                }

                _requestCount = 0;
                _resetTime = DateTime.UtcNow + _timeWindow;
            }

            _requestCount++;
        }
        finally
        {
            _semaphore.Release();
        }
    }
}
