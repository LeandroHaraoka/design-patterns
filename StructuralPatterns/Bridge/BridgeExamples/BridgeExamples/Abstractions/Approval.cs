using BridgeExamples.Implementations;
using System;

namespace BridgeExamples.Abstractions
{
    public class Approval : Order
    {
        private readonly string _approvedBy;
        private readonly DateTime _approvedAt;

        public Approval(Asset asset, string approvedBy, DateTime approvedAt) : base(asset)
        {
            _approvedBy = approvedBy;
            _approvedAt = approvedAt;
        }

        public override void Notify()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"Order Type: {nameof(Approval)}");
            Console.WriteLine($"Approved by: {_approvedBy}");
            Console.WriteLine($"Approved at: {_approvedAt.ToString()}");
            Console.WriteLine("-----------------------------------");
            _asset.NotifyDetails();
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
