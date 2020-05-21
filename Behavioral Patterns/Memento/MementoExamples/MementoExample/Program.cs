using Memento.Mementos;
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Memento");
            Console.WriteLine("Memento and Command Example");

            var originator = new Originator(0);
            var caretaker = new Caretaker(originator);

            // 1 + 2 + 3 + 4 + 5 = 15 (state)
            for (var i = 1; i <= 5; i++) originator.Add(i);
            caretaker.Backup();

            // 15 - 10 = 5 (state)
            originator.Subtract(10);
            caretaker.Backup();

            // 5 * 8 = 40 (state)
            originator.MultiplyBy(8);
            caretaker.Backup();

            // 40 / 20 = 2 (state)
            originator.DivideBy(20);
            caretaker.Backup();

            for (int i = 0; i <= 10; i++) caretaker.RestorePreviousState();
        }
    }
}
