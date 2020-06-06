using System;
using System.Collections.Generic;

namespace AuthenticationExample.Repositories
{
    public class AuthenticationTokenContext
    {
        public readonly IDictionary<Guid, string> Tokens = new Dictionary<Guid, string>();
    }
}
