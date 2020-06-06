using System;

namespace AuthenticationExample.Repositories
{
    public interface ITokenWriter
    {
        void Save(Guid userId, string accessToken);
    }

    public class TokenWriter : ITokenWriter
    {
        private readonly AuthenticationTokenContext _context;

        public TokenWriter(AuthenticationTokenContext context)
        {
            _context = context;
        }

        public void Save(Guid userId, string accessToken)
        {
            Console.WriteLine("\n[Repository] Saving token");
            Console.WriteLine($"UserId: {userId}");
            Console.WriteLine($"Saved Token: {accessToken}");
            _context.Tokens[userId] = accessToken;
        }
    }
}
