using System.Collections;
using System.Collections.Generic;

namespace BinaryTreeExample.BinaryTrees
{
    public class InOrderIterator<T> : IEnumerator<T>
    {
        public Node<T> CurrentNode { get; set; }
        private readonly Node<T> _root;
        private bool yieldedStart;

        public InOrderIterator(Node<T> root)
        {
            _root = CurrentNode = root;

            while (CurrentNode.Left != null)
                CurrentNode = CurrentNode.Left;
        }

        public void Reset()
        {
            CurrentNode = _root;
            yieldedStart = true;
        }

        public bool MoveNext()
        {
            if (!yieldedStart)
            {
                yieldedStart = true;
                return true;
            }

            if (CurrentNode.Right != null)
            {
                CurrentNode = CurrentNode.Right;
                MoveToLeftChild(CurrentNode.Left);
                return true;
            }

            var parentOfLastParent = MoveToParent(CurrentNode.Parent);

            CurrentNode = parentOfLastParent;

            return CurrentNode != null;
        }

        private void MoveToLeftChild(Node<T> node)
        {
            if (CurrentNode.Left != null)
            {
                CurrentNode = CurrentNode.Left;
                MoveToLeftChild(node.Left);
            }
        }

        private Node<T> MoveToParent(Node<T> currentParent)
        {
            if (currentParent != null && CurrentNode == currentParent.Right)
            {
                CurrentNode = currentParent;
                MoveToParent(currentParent.Parent);
            }
            return CurrentNode.Parent;
        }

        object IEnumerator.Current => CurrentNode.Value;
        T IEnumerator<T>.Current => CurrentNode.Value;

        public void Dispose()
        {
        }
    }
}
