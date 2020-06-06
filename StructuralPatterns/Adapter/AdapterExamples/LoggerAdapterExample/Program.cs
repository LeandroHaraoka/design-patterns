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

            var deprecatedService = new ClientService(new LogLibrary());
            deprecatedService.SomeServiceAction();

            var newService = new ClientService(new LoggerAdapter(new CustomLogger()));
            newService.SomeServiceAction();
        }
    }
}
