using System;

namespace BookTraderExample.Assets.Movements
{
    public abstract class Movement
    {
        protected readonly DateTime _withdrawDate;
        protected readonly decimal _price;
        protected readonly decimal _volume;

        protected Movement(DateTime withdrawDate, decimal price, decimal volume)
        {
            _withdrawDate = withdrawDate;
            _price = price;
            _volume = volume;
        }

        public abstract void PrintDetails();
    }
}
