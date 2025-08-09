using Microsoft.Kiota.Abstractions;

namespace Autodesk.Common.HttpClientLibrary.Middleware.Options;

public class RateLimitingHandlerOption : IRequestOption
{
    /// <summary>
    /// Maximum number of requests allowed within the specified time window.
    /// </summary>
    private int _maxConcurrentRequests = 0;

    /// <summary>
    /// Time window for the rate limiting.
    /// </summary>
    private TimeSpan _timeWindow = TimeSpan.Zero;

    public (int maxConcurrentRequests, TimeSpan timeWindow)? GetRateLimit()
    {
        if (_timeWindow == TimeSpan.Zero || _maxConcurrentRequests == 0)
            return null;

        return (_maxConcurrentRequests, _timeWindow);
    }
    /// <summary>
    /// Sets the rate limit parameters.
    /// </summary>
    /// <param name="maxConcurrentRequests">Maximum number of concurrent requests.</param>
    /// <param name="timeWindow">Time window for the rate limiting in seconds.</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public void SetRateLimit(int maxConcurrentRequests, TimeSpan timeWindow)
    {
        if (maxConcurrentRequests <= 0)
            throw new ArgumentOutOfRangeException(nameof(maxConcurrentRequests), "Max concurrent requests must be greater than zero.");

        _maxConcurrentRequests = maxConcurrentRequests;

        if (timeWindow == TimeSpan.Zero )
            throw new ArgumentOutOfRangeException(nameof(timeWindow), "Time window must be greater than zero.");
        _timeWindow = timeWindow;
    }

    public void Disable()
    {
        _maxConcurrentRequests = 0;
        _timeWindow = TimeSpan.Zero;
    }

}
