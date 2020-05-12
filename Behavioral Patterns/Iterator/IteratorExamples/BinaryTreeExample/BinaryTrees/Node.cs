using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeExample.BinaryTrees
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Left;
        public Node<T> Right;
        public Node<T> Parent;

        public Node(T value, Node<T> left, Node<T> right)
        {
            Value = value;
            Left = left;
            Right = right;

            if (left != null) left.Parent = this;
            if (right != null) right.Parent = this;
        }
    }
}
