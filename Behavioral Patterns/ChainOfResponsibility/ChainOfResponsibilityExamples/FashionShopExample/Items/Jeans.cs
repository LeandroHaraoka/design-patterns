using FashionShopExample.Discounts;

namespace FashionShopExample.Items
{
    public class Jeans : Item
    {
        public Jeans(DiscountApplier discountApplier, decimal price) : base(discountApplier)
        {
            _price = price;
            _name = ItemNames.Jeans;
        }
    }
}
