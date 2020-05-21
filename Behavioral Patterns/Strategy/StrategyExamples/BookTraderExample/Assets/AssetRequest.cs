using System;
using System.Collections.Generic;

namespace BookTraderExample.Assets
{
    public class AssetRequest
    {
        public AssetTypes AssetType { get; set; }
        public Guid Buyer { get; set; }
        public Guid Seller { get; set; }
        public DateTime TradeDate { get; set; }
        public IList<MovementRequest> Movements { get; set;}
    }

    public enum AssetTypes { Cash, Bond, Forex, Stock, Commodity }
}
