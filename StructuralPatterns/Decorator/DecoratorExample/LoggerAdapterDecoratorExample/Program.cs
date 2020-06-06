using LoggerAdapterDecoratorExample.CommandCenter;
using LoggerAdapterDecoratorExample.Logs;
using System;

namespace LoggerAdapterDecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator and Adapter");
            Console.WriteLine("Logger Adapter Decorator Example\n");

            var order = new Order(Guid.NewGuid(), "Product", "BuyerName", "SellerName", 2.50m, 1);

            var orderNotifier = new OrderNotifierDecorator(
                new LogLibrary(),
                new EmailNotifierAdapter(new EmailNotifier()));

            //new LogLibrary().NotifyExecution(order);
            //new LogLibrary().NotifyCancellation(order);

            orderNotifier.NotifyExecution(order);
            orderNotifier.NotifyCancellation(order);
        }
    }
}
