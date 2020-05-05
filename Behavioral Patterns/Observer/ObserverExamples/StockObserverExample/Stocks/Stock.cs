using System;
using System.Collections.Generic;

namespace StockObserverExample.Stocks
{
    public class Stock : ISubject
    {
        private readonly IList<IStockPriceObserver> _observers = new List<IStockPriceObserver>();
        private decimal _price;
        private string _identifier;

        public Stock(decimal initialPrice, string identifier)
        {
            _price = initialPrice;
            _identifier = identifier;
            Console.WriteLine($"\nNew Stock Registered {_identifier}");
            Console.WriteLine($"Initial Price: {decimal.Round(_price,4)}");
        }

        public void Attach(IStockPriceObserver observer)
        {
            if (observer != null)
                _observers.Add(observer);
        }

        public void Detach(IStockPriceObserver observer)
        {
            if (observer != null)
                _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_price, _identifier);
            }
        }

        public void UpdatePrice(decimal value)
        {
            _price = value;
            NotifyObservers();
        }
    }
}
