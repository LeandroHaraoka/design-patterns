using System.Collections;
using System.Collections.Generic;

namespace ForeachExample.BidirectionalCollections
{
    public class CustomIterator<T> : IEnumerator<T>
    {
        private readonly BidirectionalCollection<T> _iterableCollection;
        private int _position = -1;
        private readonly bool _reverse;

        public T Current => _iterableCollection.GetItemAt(_position);

        object IEnumerator.Current => _iterableCollection.GetItemAt(_position);

        public CustomIterator(BidirectionalCollection<T> iterableCollection, bool reverse)
        {
            _iterableCollection = iterableCollection;
            _reverse = reverse;

            if (_reverse)
                _position = iterableCollection.GetSize();
        }

        public bool MoveNext()
        {
            var nextPosition = _reverse ? _position - 1 : _position + 1;

            if (nextPosition < 0 || nextPosition >= _iterableCollection.GetSize())
                return false;

            _position = nextPosition;
            return true;
        }

        public void Reset()
        {
            _position = _reverse ? _iterableCollection.GetSize() : -1;
        }

        public void Dispose()
        {
        }
    }
}
