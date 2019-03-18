/*--------------------------------------------------------------------------------*
            MemCacheManager .Net Core 2.2 Memory Caching Library - By Paul Marrable
            
               This libary is free to use but please leave this comment here :)
*---------------------------------------------------------------------------------*/

using System;

namespace Caching.MemCache.Contracts
{
    public interface ICachingManager
    {
        void ClearAllCache();
        T GetCache<T>(CacheKeys key);
        T GetCache<T>(string key);
        void RemoveCache(CacheKeys key);
        void RemoveCache(string key);
        T SetCache<T>(T obj, CacheKeys cacheKey, TimeSpan? timeSpan = null, bool useRollingInterval = false, int entrySize = 1);
        T SetCache<T>(T obj, string key, TimeSpan? timeSpan = null, bool useRollingInterval = false, int entrySize = 1);
    }
}