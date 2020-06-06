using AuthenticationExample.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationExample.Decorators
{
    public class TokenCryptographyWriter : TokenWriterDecorator
    {
        public TokenCryptographyWriter(ITokenWriter tokenWriter) : base(tokenWriter)
        {
        }

        public override void Save(Guid userId, string accessToken)
        {
            var encryptedToken = Convert.ToBase64String(Encoding.Unicode.GetBytes(accessToken));
            Console.WriteLine("\n[Cryptography] Encrypting token");
            Console.WriteLine($"Before: {accessToken}");
            Console.WriteLine($"After: {encryptedToken}");
            _tokenWriter.Save(userId, encryptedToken);
        }
    }
}
