using System;
using System.Timers;

namespace FashionShopExample.Discounts
{
    public abstract class Discount
    {
        private readonly DiscountApplier _discountApplier;
        protected decimal _rate = 0.1m;

        public Discount(DiscountApplier discountApplier)
        {
            _discountApplier = discountApplier;
        }

        public void Add()
        {
            _discountApplier.DiscountsEvent += OnDiscountEvent;
        }

        public virtual void OnDiscountEvent(object sender, DiscountEventArgs discountEventArgs)
        {
            discountEventArgs._finalPrice *= (1 - _rate);
        }

        protected void OnDiscountExpiration(object sender, ElapsedEventArgs e)
        {
            _discountApplier.DiscountsEvent -= OnDiscountEvent;
        }
    }
}
