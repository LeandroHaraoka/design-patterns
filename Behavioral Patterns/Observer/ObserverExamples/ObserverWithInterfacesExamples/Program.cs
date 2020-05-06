using ObserverWithInterfacesExamples.Stocks;
using System;

namespace ObserverWithInterfacesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer");
            Console.WriteLine("Observer With Interfaces Example");

            var stockInitialPrice = 20m;
            var stock = new Stock(stockInitialPrice);

            var stockPriceDisplay = new StockPriceDisplay();
            var subscription = stock.Subscribe(stockPriceDisplay);

            stock.UpdatePrice(22m);
            stock.UpdatePrice(23m);
            stock.UpdatePrice(25m);
            stock.UpdatePrice(24m);
            stock.UpdatePrice(20m);
            stock.UpdatePrice(25m);

            subscription.Dispose();
        
            stock.UpdatePrice(25m);
            stock.UpdatePrice(20m);
        }
    }
}
