# MemCacheManager
.Net core 2.2 library for managing memory cache.
<p>
MemCacheManger is a small library to help keep memory caching clean and simple. MemCachManager abstract out the caching out into its own class so you can easily configure your global and default caching options
</p>

<h2>
Setup
</h2>
<h4>Regsitering the services</h4>
<p>
First things first, register the AddMemoryCache service <code>services.AddMemoryCache();</code> in your ConfigureServices method in startup.cs
</p>
<p>
Then register the MemCachManager by adding  services.AddTransient&lt;ICachingManager, CachingManager&gt;(); </code>

<p>
Then register you Custom Mem Cache class. There is an example of this class in the library called YourCustomMemoryCache.cs <br/>
Register this class like so <br/> <code>services.AddSingleton&lt;ICustomMemCache, YourCustomMemoryCache&gt;(); </code> 
</p>

You can also specify the size limit of you cache through the constructor...like so <br/>
<code>services.AddSingleton&lt;ICustomMemCache&gt;(new YourCustomMemoryCache(1024));</code>
</p>

<h4>Adding you keys</h4>
<p>MemCacheManager stores the caching keys in an enum to help maintain integrity. </p>
<p>The keys are store in a file called KeyStore.cs under the CacheKeys enum, when you have a new object to cache you will need to register a new key first </p>
<p><strong>Note:</strong> MemCacheManager exposes overflow methods for setting and getting cache via string keys, but these are best used when the key is a dynamic value. </p>

<h4>Getting and setting cache</h4>
<p>
  First inject the CachingManager through DI 
  </p>

        private readonly ICachingManager _cachingController;     
        
        public YourClass(ICachingManager cachingController)
        {
          _cachingController = cachingController;
        }
   </code>
   
   <p>Attempt to get the cache with the GetCache method
   <code>_cachingController.GetCache<IEnumerable<YourObjectType>>(CacheKeys.YourCacheKey)</code>
   </p>   
   <p>
      If the key has no cached object against it, it will return null. 
   </p>
   <p>
    To set the cache, use the SetCache method <code>  _cachingController.SetCache(YourObject, CacheKeys.YourCacheKey); </code> <br/>
    SetCache returns the object you put in.
    </code>
    <p>So a nice clean way to get and set your cache is through a ternary operator...like so </p>
    

     var foo = _cachingController.GetCache<IEnumerable<YourObjectType>>(CacheKeys.YourCacheKey) ?? 
                    _cachingController.SetCache(YourObject, CacheKeys.YourCacheKey);
                   
   </p>
   
   The SetCache method has a number of optional parameters for setting caching options per entry. <br/>
   <code>timeSpan</code>: TimeSpan = set how long the entry will live in memory. Default is 1 hour. <br/>
   <code>useRollingInterval</code>: bool = Rolling interval will reset the timeSpan each time it has been set. Default is false <br>
   <code>entrySize</code>:int Set how much space in the allowed caching size limit then entry will take. Default is 1
   
   
   
   
     


