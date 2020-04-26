using FinancialExample.Aggregates.ValueTypes;
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

            Console.WriteLine("\n[Cash Order]");
            CreateOrder(AssetType.Cash);
            Console.WriteLine("\n[Cash Deal]");
            CreateDeal(AssetType.Cash);

            Console.WriteLine("\n[Bond Order]");
            CreateOrder(AssetType.Bond);
            Console.WriteLine("\n[Bond Deal]");
            CreateDeal(AssetType.Bond);
        }

        private static void CreateOrder(AssetType assetType)
        {
            var factory = FinancialFactory.GetFactory(assetType);
            var order = factory.CreateOrder();
            PrintAggregateDetails(order);
        }

        private static void CreateDeal(AssetType assetType)
        {
            var factory = FinancialFactory.GetFactory(assetType);
            var deal = factory.CreateDeal();
            PrintAggregateDetails(deal);
        }

        private static void PrintAggregateDetails(object aggregate)
        {
            Console.WriteLine($"Aggregate type: {aggregate.GetType().Name}");
        }
    }
}
