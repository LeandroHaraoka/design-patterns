using System;

namespace BridgeExamples.Implementations
{
    public class Commodity : Asset
    {
        private readonly Commodities _product;

        public Commodity(DateTime date, decimal price, decimal volume, Commodities product) 
            : base(date, price, volume)
        {
            _product = product;
        }

        public override void NotifyDetails()
        {
            Console.WriteLine($"Asset Type: {nameof(Commodity)}");
            Console.WriteLine($"Product: {_product}");
            Console.WriteLine($"Date: {_date.ToShortDateString()}");
            Console.WriteLine($"Price: {_price}");
            Console.WriteLine($"Volume: {_volume}");
        }
    }

    public enum Commodities { GOLD, OIL, WHEAT }
}
