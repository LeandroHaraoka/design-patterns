using BridgeExamples.Abstractions;
using BridgeExamples.Implementations;
using System;
using static BridgeExamples.Implementations.Commodities;
using static BridgeExamples.Implementations.StockCodes;

namespace BridgeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge");
            Console.WriteLine("Order and Assets Example");

            var commodity = new Commodity(new DateTime(2020, 05, 30), 1700m, 1m, GOLD);
            var stock = new Stock(new DateTime(2020, 03, 30), 230M, 1m, FB);

            NotifyOrders(commodity);
            NotifyOrders(stock);
        }

        private static void NotifyOrders(Asset asset)
        {
            var solicitation = new Solicitation(asset);
            var approval = new Approval(asset, "Approver", DateTime.UtcNow);
            var cancellation = new Cancellation(asset, "Canceler", DateTime.UtcNow, "Incorrect order.");

            solicitation.Notify();
            approval.Notify();
            cancellation.Notify();
        }
    }
}
