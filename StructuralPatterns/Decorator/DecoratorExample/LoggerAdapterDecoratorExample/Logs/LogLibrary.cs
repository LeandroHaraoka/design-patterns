using System;

namespace LoggerAdapterDecoratorExample.Logs
{
    public class LogLibrary : IOrderNotifier
    {
        public void NotifyCancellation(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[LogLibrary]");
            Console.WriteLine("An order Cancellation occurred.");
            Console.WriteLine(OrderMessage.Create(order));
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void NotifyExecution(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[LogLibrary]");
            Console.WriteLine("New order executed.");
            Console.WriteLine(OrderMessage.Create(order));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
