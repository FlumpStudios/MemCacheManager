/*--------------------------------------------------------------------------------*
            MemCacheManager .Net Core 2.2 Memory Caching Library - By Paul Marrable
            
               This libary is free to use but please leave this comment here :)
*---------------------------------------------------------------------------------*/

using Microsoft.Extensions.Caching.Memory;
using FiLogger.Caching.MemCache.Contracts;

namespace FiLogger.Caching.MemCache
{
    public class YourCustomerMemoryCache : ICustomMemCache
    {
        public MemoryCache Cache { get; set; }
        public YourCustomerMemoryCache(int sizeLimit = 1000)
        {
            Cache = new MemoryCache(new MemoryCacheOptions
            {
                SizeLimit = sizeLimit                
            });
        }
    }
}
