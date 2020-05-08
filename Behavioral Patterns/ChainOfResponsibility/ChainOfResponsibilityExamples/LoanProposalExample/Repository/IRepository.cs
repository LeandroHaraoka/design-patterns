using System;
using System.Collections.Generic;

namespace LoanProposalExample.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> Find(Func<T, bool> filter);
    }
}
