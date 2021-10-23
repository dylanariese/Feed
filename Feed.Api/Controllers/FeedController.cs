using Feed.Data.Classes.Feed;
using Feed.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feed.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly ICacheLayer cacheLayer;
        private readonly IFeed feedService;

        public FeedController(IConfiguration configuration, ICacheLayer cacheLayer, IFeed feedService)
        {
            this.configuration = configuration;
            this.cacheLayer = cacheLayer;
            this.feedService = feedService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int skip, int take)
        {
            var response = await cacheLayer.Cache("Games", new TimeSpan(10, 0, 0), () =>
                                                   feedService.GetDataAsync<Rss>(configuration["Nu:Games"]));

            var items = response?.Channel?.Item?.Skip(skip).Take(take).ToList() ?? new List<Item>();

            return Ok(items);
        }
    }
}