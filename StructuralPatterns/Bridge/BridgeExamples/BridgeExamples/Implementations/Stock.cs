using System;

namespace BridgeExamples.Implementations
{
    public class Stock : Asset
    {
        private readonly StockCodes _code;

        public Stock(DateTime date, decimal price, decimal volume, StockCodes code)
            : base(date, price, volume)
        {
            _code = code;
        }

        public override void NotifyDetails()
        {
            Console.WriteLine($"Asset Type: {nameof(Stock)}");
            Console.WriteLine($"Code: {_code}");
            Console.WriteLine($"Date: {_date.ToShortDateString()}");
            Console.WriteLine($"Price: {_price}");
            Console.WriteLine($"Volume: {_volume}");
        }
    }

    public enum StockCodes { FB, AMZN, MSFT }
}
