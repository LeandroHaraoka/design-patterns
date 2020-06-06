using AuthenticationExample.Repositories;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace AuthenticationExample.Decorators
{
    public class TokenCacheReader : TokenReaderDecorator
    {
        private readonly IMemoryCache _memoryCache;

        public TokenCacheReader(ITokenReader tokenReader,IMemoryCache memoryCache) 
            : base(tokenReader)
        {
            _memoryCache = memoryCache;
        }

        public override string Read(Guid userId)
        {
            Console.WriteLine("\n[Memory Cache] Retrieving token");
            Console.WriteLine($"UserId: {userId}");

            _memoryCache.TryGetValue<string>(userId, out var accessToken);
                
            return accessToken ?? _tokenReader.Read(userId);
        }
    }
}
