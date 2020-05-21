using AssetExample.Assets.Movements.ValueObjects;
using BookTraderExample.Assets;
using BookTraderExample.Assets.Movements;
using System;

namespace AssetExample.Assets.Movements
{
    public class CommodityMovement : Movement
    {
        protected readonly CommodityIdentifier _commodityIdentifier;

        public CommodityMovement(DateTime withdrawDate, decimal price, CommodityIdentifier commodityIdentifier, decimal volume)
            : base(withdrawDate, price, volume)
        {
            _commodityIdentifier = commodityIdentifier;
        }

        public override void PrintDetails()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Withdraw Date: {_withdrawDate.ToShortDateString()}");
            Console.WriteLine($"Volume: {_volume}");
            Console.WriteLine($"Price: $ {_price}");
            Console.WriteLine($"Commodity Identifier: {_commodityIdentifier}");
        }
    }
}
