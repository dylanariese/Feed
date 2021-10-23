using Feed.Data.Interfaces;
using System.Threading.Tasks;

namespace Feed.Business
{
    public class FeedService : IFeed
    {
        private readonly IHttpClient client;
        private readonly ISerialization serializer;

        public FeedService(IHttpClient client, ISerialization serializer)
        {
            this.client = client;
            this.serializer = serializer;
        }

        public async Task<T> GetDataAsync<T>(string url) where T : class
        {
            var response = await client.GetAsync(url);

            var dtos = serializer.Deserialize<T>(response);

            return dtos;
        }
    }
}