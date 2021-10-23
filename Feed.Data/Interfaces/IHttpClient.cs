using System.Net.Http;
using System.Threading.Tasks;

namespace Feed.Data.Interfaces
{
    public interface IHttpClient
    {
        Task<string> GetAsync(string url);

        Task PostAsync(string url, HttpContent content);
    }
}