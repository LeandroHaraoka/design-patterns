using FashionShopExample.Discounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FashionShopExample.Items
{
    public abstract class Item
    {
        private DiscountApplier _discountApplier;
        protected decimal _price;
        public ItemNames _name;

        public Item(DiscountApplier discountApplier)
        {
            _discountApplier = discountApplier;
        }

        public decimal Price
        {
            get
            {
                var discount = new DiscountEventArgs(_name, _price);
                _discountApplier.Apply(this, discount);
                return discount._finalPrice;
            }
        }
    }

    public enum ItemNames
    {
        Hat,
        Jeans,
        Shirt,
        Sunglasses
    }
}
