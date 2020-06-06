using AuthenticationExample.Repositories;
using System;

namespace AuthenticationExample.Decorators
{
    public abstract class TokenReaderDecorator : ITokenReader
    {
        protected readonly ITokenReader _tokenReader;
        public TokenReaderDecorator(ITokenReader tokenReader)
        {
            _tokenReader = tokenReader;
        }

        public abstract string Read(Guid userId);
    }
}
