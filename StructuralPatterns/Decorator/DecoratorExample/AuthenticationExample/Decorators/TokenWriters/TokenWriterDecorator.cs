using AuthenticationExample.Repositories;
using System;

namespace AuthenticationExample.Decorators
{
    public abstract class TokenWriterDecorator : ITokenWriter
    {
        protected readonly ITokenWriter _tokenWriter;
        public TokenWriterDecorator(ITokenWriter tokenWriter)
        {
            _tokenWriter = tokenWriter;
        }

        public abstract void Save(Guid userId, string accessToken);
    }
}
