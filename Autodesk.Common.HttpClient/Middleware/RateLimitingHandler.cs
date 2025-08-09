using System.Collections.Concurrent;
using Autodesk.Common.HttpClientLibrary.Middleware.Options;
using Microsoft.Kiota.Http.HttpClientLibrary.Extensions;

namespace Autodesk.Common.HttpClientLibrary.Middleware;

public class RateLimitingHandler : DelegatingHandler
{
    private readonly RateLimitingHandlerOption _options;
    public RateLimitingHandler(RateLimitingHandlerOption? rateLimitingHandlerOption = null)
    {
        _options = rateLimitingHandlerOption ?? new RateLimitingHandlerOption();
    }

    private readonly ConcurrentDictionary<string, RateLimiter> _rateLimiters = new();

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var rateOptions = request.GetRequestOption<RateLimitingHandlerOption>() ?? _options;

        var rateLimit = rateOptions.GetRateLimit();

        if (rateLimit != null)
        {
            var endpoint = GetEndpoint(request);
            var rateLimiter = _rateLimiters.GetOrAdd(endpoint, (_) => new RateLimiter(rateLimit.Value.maxConcurrentRequests, rateLimit.Value.timeWindow));

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

    public RateLimiter(int maxRequests, TimeSpan timeWindow)
    {
        _maxRequests = maxRequests;
        _timeWindow = timeWindow;
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
