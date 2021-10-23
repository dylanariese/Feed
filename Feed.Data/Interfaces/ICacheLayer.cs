using System;
using System.Threading.Tasks;

namespace Feed.Data.Interfaces
{
    public interface ICacheLayer
    {
        Task<TResult> Cache<TResult>(string key, TimeSpan expiration, Func<Task<TResult>> method) where TResult : class;
    }
}