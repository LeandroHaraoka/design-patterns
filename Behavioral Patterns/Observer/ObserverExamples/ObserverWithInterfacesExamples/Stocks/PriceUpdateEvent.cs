using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverWithInterfacesExamples.Stocks
{
    public class PriceUpdateEvent
    {
        public readonly decimal _newPrice;

        public PriceUpdateEvent(decimal newPrice)
        {
            _newPrice = newPrice;
        }
    }
}
