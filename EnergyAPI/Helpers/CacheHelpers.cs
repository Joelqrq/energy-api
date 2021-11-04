using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EnergyAPI.Helpers {
    public static class CacheHelpers {

        public static async Task SetCacheAsync<T>(this IDistributedCache cache, string cacheId, T data, TimeSpan? absoluteExpireTime = null, TimeSpan? unusedExpireTime = null) {
            var options = new DistributedCacheEntryOptions();

            options.AbsoluteExpirationRelativeToNow = absoluteExpireTime ?? TimeSpan.FromSeconds(60);
            options.SlidingExpiration = unusedExpireTime;

            var jsonData = JsonSerializer.Serialize(data);
            await cache.SetStringAsync(cacheId, jsonData, options);
        }

        public static async Task<T> GetCacheAsync<T>(this IDistributedCache cache, string cacheId) {
            var jsonData = await cache.GetStringAsync(cacheId);

            if(jsonData is null) {
                return default(T);
            }

            return JsonSerializer.Deserialize<T>(jsonData);
        }
    }
}
