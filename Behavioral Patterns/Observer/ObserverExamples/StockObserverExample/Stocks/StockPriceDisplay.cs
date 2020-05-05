using System;
using System.Collections.Generic;
using System.Text;

namespace StockObserverExample.Stocks
{
    public class StockPriceDisplay : IStockPriceObserver
    {
        public void Update(decimal updatedPrice, string identifier)
        {
            Console.WriteLine($"\n{identifier} Updated Price: {decimal.Round(updatedPrice, 4)}");
        }
    }
}
