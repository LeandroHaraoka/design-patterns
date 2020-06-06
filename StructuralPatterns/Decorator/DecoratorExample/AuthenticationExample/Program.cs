using AuthenticationExample.Decorators;
using AuthenticationExample.Repositories;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace AuthenticationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator");
            Console.WriteLine("Authentication Example\n");

            var context = new AuthenticationTokenContext();
            var memoryCache = new MemoryCache(new MemoryCacheOptions());
            var token = "ewzesdw4efa498we4fw4ef98a4f984we98f4w9e8f4";
            var userId = Guid.NewGuid();

            var tokenWriter = 
                new TokenCryptographyWriter(
                    new TokenCacheWriter(
                        new TokenWriter(context), memoryCache));

            tokenWriter.Save(userId, token);
            
            var tokenReader = 
                new TokenCryptographyReader(
                    new TokenCacheReader(
                        new TokenReader(context), memoryCache));
            var retrievedToken = tokenReader.Read(userId);
        }
    }
}
