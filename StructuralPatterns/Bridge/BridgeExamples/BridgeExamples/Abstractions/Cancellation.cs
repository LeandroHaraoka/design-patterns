using BridgeExamples.Implementations;
using System;

namespace BridgeExamples.Abstractions
{
    public class Cancellation : Order
    {
        private readonly string _cancelledBy;
        private readonly DateTime _cancelledAt;
        private readonly string _reason;

        public Cancellation(Asset asset, string cancelledBy, DateTime cancelledAt, string reason) : base(asset)
        {
            _cancelledBy = cancelledBy;
            _cancelledAt = cancelledAt;
            _reason = reason;
        }

        public override void Notify()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"Order Type: {nameof(Cancellation)}");
            Console.WriteLine($"Approved by: {_cancelledBy}");
            Console.WriteLine($"Approved at: {_cancelledAt.ToString()}");
            Console.WriteLine($"Reason: {_reason}");
            Console.WriteLine("-----------------------------------");
            _asset.NotifyDetails();
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
