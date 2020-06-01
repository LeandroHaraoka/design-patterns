using System;

namespace BridgeExamples.Implementations
{
    public abstract class Asset
    {
        protected readonly Guid _id = Guid.NewGuid();
        protected readonly DateTime _date;
        protected readonly decimal _price;
        protected readonly decimal _volume;

        public Asset(DateTime date, decimal price, decimal volume)
        {
            _date = date;
            _price = price;
            _volume = volume;
        }

        public abstract void NotifyDetails();
    }
}
