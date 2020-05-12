using System.Collections;
using System.Collections.Generic;

namespace ForeachExample.BidirectionalCollections
{
    public abstract class IterableCollection<T> : IEnumerable<T>
    {
        public abstract IEnumerator<T> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
