using AuthenticationExample.Repositories;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace AuthenticationExample.Decorators
{
    public class TokenCacheWriter : TokenWriterDecorator
    {
        private readonly IMemoryCache _memoryCache;

        public TokenCacheWriter(ITokenWriter tokenWriter, IMemoryCache memoryCache) 
            : base(tokenWriter)
        {
            _memoryCache = memoryCache;
        }

        public override void Save(Guid userId, string accessToken)
        {
            _memoryCache.Set(userId, accessToken);
            Console.WriteLine("\n[Memory Cache] Saving token");
            Console.WriteLine($"UserId: {userId}");
            Console.WriteLine($"Saved Token: {accessToken}");

            _tokenWriter.Save(userId, accessToken);
        }
    }
}
