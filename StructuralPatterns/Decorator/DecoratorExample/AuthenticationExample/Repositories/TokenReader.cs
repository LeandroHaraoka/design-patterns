using System;

namespace AuthenticationExample.Repositories
{
    public interface ITokenReader
    {
        string Read(Guid userId);
    }

    public class TokenReader : ITokenReader
    {
        private readonly AuthenticationTokenContext _context;

        public TokenReader(AuthenticationTokenContext context)
        {
            _context = context;
        }

        public string Read(Guid userId)
        {
            _context.Tokens.TryGetValue(userId, out var accessToken);
            
            Console.WriteLine("\n[Repository] Retrieving token");
            Console.WriteLine($"UserId: {userId}");
            
            return accessToken;
        }
    }
}
