namespace CommonUtils;

public static class AsyncEnumerableExtensions
{
    public static async Task<List<T>> GetAll<T>(this IAsyncEnumerable<T> asyncEnumerableItems)
    {
        var allItems = new List<T>();
        await foreach (var item in asyncEnumerableItems)
        {
            allItems.Add(item);
        }

        return allItems;
    }

    public static async Task<T?> FirstOrDefault<T>(this IAsyncEnumerable<T> asyncEnumerableItems, Func<T, bool> predicate)
    {
        await foreach (var item in asyncEnumerableItems)
        {
            if (predicate(item))
                return item;
        }

        return default;
    }
}
