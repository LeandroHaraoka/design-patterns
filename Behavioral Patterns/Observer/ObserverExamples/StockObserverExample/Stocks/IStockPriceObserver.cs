using System;
using System.Collections.Generic;
using System.Text;

namespace StockObserverExample.Stocks
{
    public interface IStockPriceObserver
    {
        void Update(decimal updatedPrice, string identifier);
    }
}
