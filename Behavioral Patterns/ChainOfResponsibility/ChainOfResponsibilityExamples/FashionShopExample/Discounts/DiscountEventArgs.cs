using FashionShopExample.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace FashionShopExample.Discounts
{
    public class DiscountEventArgs
    {
        public ItemNames _itemName;
        public decimal _finalPrice;

        public DiscountEventArgs(ItemNames itemName, decimal finalPrice)
        {
            _itemName = itemName;
            _finalPrice = finalPrice;
        }
    }
}
