using System.Timers;

namespace FashionShopExample.Discounts
{
    public class FlashSale : Discount
    {
        private readonly Timer _timer;

        public FlashSale(DiscountApplier discountApplier, int expirationInMilliseconds) : base(discountApplier)
        {
            _rate = 0.05m;
            _timer = new Timer(expirationInMilliseconds);
            _timer.Elapsed += OnDiscountExpiration;
            _timer.Start();
        }
    }
}
