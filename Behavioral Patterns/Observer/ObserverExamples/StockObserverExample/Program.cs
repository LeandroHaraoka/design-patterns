using StockObserverExample.Stocks;
using System;

namespace StockObserverExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer");
            Console.WriteLine("Observer Stock Example");

            var stockInitialPrice = 20m;
            var stockIdentifier = "PETR4";
            var petr4Price = new Stock(stockInitialPrice, stockIdentifier);

            var stockValueDisplay = new StockPriceDisplay();
            var stockVariationRateDisplay = new StockPriceVariationDisplay(stockInitialPrice);

            petr4Price.Attach(stockValueDisplay);
            petr4Price.Attach(stockVariationRateDisplay);

            petr4Price.UpdatePrice(22m);
            petr4Price.UpdatePrice(23m);
            petr4Price.UpdatePrice(25m);
            petr4Price.UpdatePrice(24m);
            petr4Price.UpdatePrice(20m);
            petr4Price.UpdatePrice(25m);
            petr4Price.UpdatePrice(25m);
            petr4Price.UpdatePrice(20m);
        }
    }
}
