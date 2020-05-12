using System.Collections;
using System.Collections.Generic;

namespace BinaryTreeExample.BinaryTrees
{
    public class BinaryTree<T> : IEnumerable<T>
    {
        private readonly Node<T> _root;

        public BinaryTree(Node<T> root)
        {
            _root = root;
        }

        public IEnumerator<T> GetEnumerator() => new InOrderIterator<T>(_root);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
