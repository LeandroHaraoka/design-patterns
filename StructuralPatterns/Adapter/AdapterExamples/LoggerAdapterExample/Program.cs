using LoggerAdapterExample.CommandCenter;
using LoggerAdapterExample.Logs;
using System;

namespace LoggerAdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter");
            Console.WriteLine("Logger Adapter Example\n");

            var service = new ClientService(
                new LoggerAdapter(new LogLibrary(), new CommandCenterLogger()));

            service.SomeServiceAction();
        }
    }
}
