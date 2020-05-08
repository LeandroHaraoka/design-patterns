using System;
using System.Collections.Generic;
using System.Text;

namespace FashionShopExample.Discounts
{
    public class FirstPurchaseDiscount : Discount
    {
        public FirstPurchaseDiscount(DiscountApplier discountApplier) : base(discountApplier)
        {
            _rate = 0.20m;
        }
    }
}
