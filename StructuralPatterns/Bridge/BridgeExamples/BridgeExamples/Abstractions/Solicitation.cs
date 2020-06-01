using BridgeExamples.Implementations;
using System;

namespace BridgeExamples.Abstractions
{
    public class Solicitation : Order
    {
        public Solicitation(Asset asset) : base(asset)
        {
        }

        public override void Notify()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"Order Type: {nameof(Solicitation)}");
            Console.WriteLine("-----------------------------------");
            _asset.NotifyDetails();
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
