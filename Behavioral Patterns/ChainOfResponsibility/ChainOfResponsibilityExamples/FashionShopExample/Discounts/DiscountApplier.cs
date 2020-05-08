using System;

namespace FashionShopExample.Discounts
{
    public class DiscountApplier
    {
        public event EventHandler<DiscountEventArgs> DiscountsEvent;

        public void Apply(object sender, DiscountEventArgs discount) => DiscountsEvent?.Invoke(sender, discount);
    }
}
