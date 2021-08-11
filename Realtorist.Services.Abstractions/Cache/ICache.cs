using System.Collections.Generic;

namespace Realtorist.Services.Abstractions.Cache
{
    /// <summary>
    /// Describes data provider in cache
    /// </summary>
    /// <typeparam name="T">Key Type</typeparam>
    /// <typeparam name="V">Value Type</typeparam>
    public interface ICache<T,V> : IDictionary<T,V>
    {
    }
}
