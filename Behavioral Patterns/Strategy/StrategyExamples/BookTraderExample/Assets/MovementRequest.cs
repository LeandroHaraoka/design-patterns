using AssetExample.Assets.Movements.ValueObjects;
using System;

namespace BookTraderExample.Assets
{
    public class MovementRequest
    {
        public DateTime WithdrawDate { get; set; }
        public decimal Price { get; set; }
        public decimal Volume { get; set; }
        public Direction Direction { get; set; }
        public BondIndex Index { get; set; }
        public decimal Rate { get; set; }
        public CommodityIdentifier CommodityIdentifier { get; set; }
        public Currencies ReferenceCurrency { get; set; }
        public Currencies Currency { get; set; }
        public StockCode StockCode { get; set; }
    }
}