using ForeachExample.BidirectionalCollections;
using System;
using System.Collections.Generic;

namespace ForeachExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterator");
            Console.WriteLine("Foreach Example");

            var array = new int[] { 1, 2, 3, 4, 5 };
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var sortedDictionary = new SortedDictionary<int, string>
            {
                { 5, "five" },
                { 2, "two" },
                { 1, "one" },
                { 4, "four" },
                { 3, "three" }
            };
            var forwardList = new BidirectionalCollection<Person>()
            {
                new Person("Anna"),
                new Person("Bob"),
                new Person("Clarice"),
            };
            var reversedList = new BidirectionalCollection<Person>(true)
            {
                new Person("Anna"),
                new Person("Bob"),
                new Person("Clarice"),
            };

            Foreach(array);
            Foreach(list);
            Foreach(sortedDictionary);
            Foreach(forwardList);
            Foreach(reversedList);
        }

        private static void Foreach<T>(IEnumerable<T> collection)
        {
            Console.WriteLine($"\nExecuting iteration through collection of type { collection.GetType().Name }.");
            var enumerator = collection.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
