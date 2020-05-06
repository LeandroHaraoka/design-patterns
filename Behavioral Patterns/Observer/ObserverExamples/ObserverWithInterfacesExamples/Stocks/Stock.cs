using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverWithInterfacesExamples.Stocks
{
    public class Stock : IObservable<PriceUpdateEvent>
    {
        private decimal _price;
        private readonly HashSet<Subscription> _subscriptions = new HashSet<Subscription>();

        public Stock(decimal initialprice)
        {
            _price = initialprice;
        }

        public void NotifyObservers()
        {
            foreach (var subscription in _subscriptions)
            {
                subscription.Observer.OnNext(new PriceUpdateEvent(_price));
            }
        }

        public void UpdatePrice(decimal value)
        {
            _price = value;
            NotifyObservers();
        }

        public IDisposable Subscribe(IObserver<PriceUpdateEvent> observer)
        {
            var subscription = new Subscription(this, observer);
            _subscriptions.Add(subscription);
            return subscription;
        }

        // A subscription instance is stored to allow disposing observers.
        // Is not possible to directly dispose observers, because they are attached to events.
        public class Subscription : IDisposable
        {
            private readonly Stock _stock;
            public IObserver<PriceUpdateEvent> Observer { get; set; }

            public Subscription(Stock stock, IObserver<PriceUpdateEvent> observer)
            {
                _stock = stock;
                Observer = observer;
            }

            public void Dispose()
            {
                _stock._subscriptions.Remove(this);
            }
        }
    }
}
