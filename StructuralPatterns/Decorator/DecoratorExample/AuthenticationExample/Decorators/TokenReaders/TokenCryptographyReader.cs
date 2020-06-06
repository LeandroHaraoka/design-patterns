using AuthenticationExample.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationExample.Decorators
{
    public class TokenCryptographyReader : TokenReaderDecorator
    {
        public TokenCryptographyReader(ITokenReader tokenReader) : base(tokenReader)
        {
        }

        public override string Read(Guid userId)
        {
            var accessToken = _tokenReader.Read(userId);
            var decryptedToken = Encoding.Unicode.GetString(Convert.FromBase64String(accessToken));
            Console.WriteLine("\n[Cryptography] Decrypting token");
            Console.WriteLine($"Before: {accessToken}");
            Console.WriteLine($"After: {decryptedToken}");
            return decryptedToken;
        }
    }
}
