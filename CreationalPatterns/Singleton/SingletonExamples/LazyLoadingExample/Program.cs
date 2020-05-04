using LazyLoadingExample.Logs;
using System;

namespace LazyLoadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton");
            Console.WriteLine("Singleton Lazy Loading Example");

            var firstInstance = Logger.GetInstance();
            var secondInstance = Logger.GetInstance();

            Console.WriteLine($"\nHas Logger.GetInstance generated a single instance? {firstInstance == secondInstance}");
        }
    }
}
