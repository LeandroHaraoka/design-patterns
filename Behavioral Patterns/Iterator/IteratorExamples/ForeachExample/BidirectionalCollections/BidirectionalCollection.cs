using System.Collections.Generic;

namespace ForeachExample.BidirectionalCollections
{
    public class BidirectionalCollection<T> : IterableCollection<T>
    {
        private readonly IList<T> _items = new List<T>();
        private readonly bool _reverse;

        public BidirectionalCollection(bool reverse = false)
        {
            _reverse = reverse;
        }

        public void Add(T item) => _items.Add(item);

        public int GetSize() => _items.Count;

        public T GetItemAt(int position) => _items[position];

        public override IEnumerator<T> GetEnumerator() => new CustomIterator<T>(this, _reverse);
    }
}
