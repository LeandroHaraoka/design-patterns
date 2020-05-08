using FashionShopExample.Discounts;

namespace FashionShopExample.Items
{
    public class Shirt : Item
    {
        public Shirt(DiscountApplier discountApplier, decimal price) : base(discountApplier)
        {
            _price = price;
            _name = ItemNames.Shirt;
        }
    }
}
