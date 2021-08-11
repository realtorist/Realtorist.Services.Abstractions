namespace Realtorist.Services.Abstractions.Cache
{
    /// <summary>
    /// Describes factory to get cache provider
    /// </summary>
    public interface ICacheFactory
    {
        /// <summary>
        /// Gets cache provider of specified capacity
        /// </summary>
        /// <typeparam name="T">Key Type</typeparam>
        /// <typeparam name="V">Value type</typeparam>
        /// <param name="capacity">Max cache capacity</param>
        /// <returns>Cache </returns>
        ICache<T, V> GetCache<T, V>(int capacity);
    }
}
