using System;
using System.Collections.Generic;
using System.Text;

namespace StockObserverExample.Stocks
{
    public interface ISubject
    {
        void Attach(IStockPriceObserver observer);
        void Detach(IStockPriceObserver observer);
        void NotifyObservers();
    }
}
