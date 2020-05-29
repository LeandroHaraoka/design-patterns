using LegacyCodesExample.Adapters;
using System;

namespace LegacyCodesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter");
            Console.WriteLine("Legacy Code Example\n");

            var service = new ClientService(new ComplexFinancialCalculusAdapter());

            service.Execute();
        }
    }
}
