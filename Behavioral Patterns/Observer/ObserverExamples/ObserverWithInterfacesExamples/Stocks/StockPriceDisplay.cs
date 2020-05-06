using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverWithInterfacesExamples.Stocks
{
    public class StockPriceDisplay : IObserver<PriceUpdateEvent>
    {
        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(PriceUpdateEvent priceUpdateEvent)
        {
            Console.WriteLine($"\nUpdated Price: {decimal.Round(priceUpdateEvent._newPrice, 4)}");
        }
    }
}
