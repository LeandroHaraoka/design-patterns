using FinancialExample.Factories;
using System;

namespace FinancialExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory");
            Console.WriteLine("Financial Example");

            var cashFactory = new CashFactory();
            var bondFactory = new BondFactory();

            Console.WriteLine("\n[Cash Order]");
            CreateOrder(cashFactory);
            Console.WriteLine("\n[Cash Deal]");
            CreateDeal(cashFactory);

            Console.WriteLine("\n[Bond Order]");
            CreateOrder(bondFactory);
            Console.WriteLine("\n[Bond Deal]");
            CreateDeal(bondFactory);
        }

        private static void CreateOrder(IFinancialFactory factory)
        {
            var order = factory.CreateOrder();
            PrintAggregateDetails(order);
        }

        private static void CreateDeal(IFinancialFactory factory)
        {
            var deal = factory.CreateDeal();
            PrintAggregateDetails(deal);
        }

        private static void PrintAggregateDetails(object aggregate)
        {
            Console.WriteLine($"Aggregate type: {aggregate.GetType().Name}");
        }
    }
}
