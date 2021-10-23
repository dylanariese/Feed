using Feed.Data.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Threading.Tasks;

namespace Feed.Infrastructure
{
    public class CacheLayer : ICacheLayer
    {
        private readonly IMemoryCache cache;

        public CacheLayer(IMemoryCache cache)
        {
            this.cache = cache;
        }

        public async Task<TResult> Cache<TResult>(string key, TimeSpan expiration, Func<Task<TResult>> method) where TResult : class
        {
            if (!cache.TryGetValue(key, out object value))
            {
                await Task.Run(() => Store(key, expiration, method));
            }

            var result = cache.Get(key) as TResult;

            return result;
        }

        public async Task<(T1, T2)> Cache<T1, T2>(string key, TimeSpan expiration, Func<Task<(T1, T2)>> method) where T1 : class
        {
            if (!cache.TryGetValue(key, out object value))
            {
                await Task.Run(() => Store(key, expiration, method));
            }

            var result = cache.Get(key) as dynamic;

            return result;
        }

        private async Task Store<TResult>(string key, TimeSpan expiration, Func<Task<TResult>> method)
        {
            var value = await method();

            cache.Set(key, value, expiration);
        }
    }
}