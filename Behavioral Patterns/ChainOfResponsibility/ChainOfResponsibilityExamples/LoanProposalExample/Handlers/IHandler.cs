using System;
using System.Collections.Generic;
using System.Text;

namespace LoanProposalExample.Handlers
{
    public interface IHandler<T>
    {
        T Handle(T request);
        IHandler<T> SetNext(IHandler<T> handler);
    }
}
