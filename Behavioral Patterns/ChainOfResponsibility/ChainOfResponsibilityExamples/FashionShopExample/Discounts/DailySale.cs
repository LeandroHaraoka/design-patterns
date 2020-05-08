using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace FashionShopExample.Discounts
{
    public class DailySale : Discount
    {
        private readonly Timer _timer;

        public DailySale(DiscountApplier discountApplier) : base(discountApplier)
        {
            _rate = 0.50m;

            _timer = new Timer(15000);      // Ten seconds just to visualize the funcionallity.
            _timer.Elapsed += OnDiscountExpiration;
            _timer.Start();
        }
    }
}
