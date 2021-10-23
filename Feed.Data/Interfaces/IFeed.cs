using System.Threading.Tasks;

namespace Feed.Data.Interfaces
{
    public interface IFeed
    {
        Task<T> GetDataAsync<T>(string url) where T : class;
    }
}
