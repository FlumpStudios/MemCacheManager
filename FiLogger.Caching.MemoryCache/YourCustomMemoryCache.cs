/*--------------------------------------------------------------------------------*
            MemCacheManager .Net Core 2.2 Memory Caching Library - By Paul Marrable
            
               This libary is free to use but please leave this comment here :)
*---------------------------------------------------------------------------------*/

using Microsoft.Extensions.Caching.Memory;
using Caching.MemCache.Contracts;

namespace Caching.MemCache
{
    public class YourCustomMemoryCache : ICustomMemCache
    {
        public MemoryCache Cache { get; set; }
        public YourCustomMemoryCache(int sizeLimit = 1000)
        {
            Cache = new MemoryCache(new MemoryCacheOptions
            {
                SizeLimit = sizeLimit                
            });
        }
    }
}
