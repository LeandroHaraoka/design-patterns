using FashionShopExample.Discounts;

namespace FashionShopExample.Items
{
    public class Sunglasses : Item
    {
        public Sunglasses(DiscountApplier discountApplier, decimal price) : base(discountApplier)
        {
            _price = price;
            _name = ItemNames.Sunglasses;
        }
    }
}
