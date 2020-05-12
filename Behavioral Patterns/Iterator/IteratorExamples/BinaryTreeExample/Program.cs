using System;
using BinaryTreeExample.BinaryTrees;

namespace BinaryTreeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterator");
            Console.WriteLine("Binary Tree Example");

            //         1
            //        / \
            //       2   3
            //      /     \
            //     4       5
            //    / \     / \
            //   6   7   8   9

            Console.WriteLine($"\nCreating in order binary tree: 6-4-7-2-1-3-8-5-9");

            var six = new Node<int>(6, null, null);
            var seven = new Node<int>(7, null, null);
            var eight = new Node<int>(8, null, null);
            var nine = new Node<int>(9, null, null);
            var four = new Node<int>(4, six, seven);
            var five = new Node<int>(5, eight, nine);
            var two = new Node<int>(2, four, null);
            var three = new Node<int>(3, null, five);
            var one = new Node<int>(1, two, three);

            var binaryTree = new BinaryTree<int>(one);

            foreach (var node in binaryTree)
                Console.WriteLine(node);
        }
    }
}
