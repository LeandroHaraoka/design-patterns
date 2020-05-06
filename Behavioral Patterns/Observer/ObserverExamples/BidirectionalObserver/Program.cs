using BidirectionalObserver.Observers;
using System;

namespace BidirectionalObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer");
            Console.WriteLine("Bidirectional Observer Example");

            var database = new Database();
            var window = new Window(database);

            using (var bidirectionalBinding = new BidirectionalBinding(
                database, () => database.ProductName, window, () => window.DisplayName))
            {
                UpdateNameViaDatabase("Name1");
                UpdateNameViaWindow("Name2");
                UpdateNameViaDatabase("Name3");
                UpdateNameViaWindow("Name4");
            }

            void UpdateNameViaDatabase(string name)
            {
                Console.WriteLine("\nUpdating names via Database.");
                database.ProductName = name;
            }
            void UpdateNameViaWindow(string name)
            {
                Console.WriteLine("\nUpdating names via window.");
                window.DisplayName = name;
            }
        }
    }
}
