using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTraderExample.Handlers
{
    public interface IHandler<T>
    {
        T Handle(T request);
        IHandler<T> SetNext(IHandler<T> handler);
    }
}
