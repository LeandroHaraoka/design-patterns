using HomeEventsExample.Events;
using HomeEventsExample.Listeners;
using System;
using System.Threading;

namespace HomeEventsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer");
            Console.WriteLine("Observer Stock Example");

            var person = new Person();
            var smartHouse = new SmartHouse(person);

            person.GoToWork();
            Thread.Sleep(5000);
            person.LeaveWork();
            Thread.Sleep(5000);
            person.ArriveAtHome();
        }
    }
}
