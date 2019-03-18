/*--------------------------------------------------------------------------------*
            MemCacheManager .Net Core 2.2 Memory Caching Library - By Paul Marrable
            
               This libary is free to use but please leave this comment here :)
*---------------------------------------------------------------------------------*/

using Microsoft.Extensions.Caching.Memory;

namespace Caching.MemCache.Contracts
{
    public interface ICustomMemCache
    {
        MemoryCache Cache { get; set; }
    }
}