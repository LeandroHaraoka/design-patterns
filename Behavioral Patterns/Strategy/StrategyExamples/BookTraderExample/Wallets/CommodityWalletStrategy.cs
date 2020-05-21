using AssetExample.Assets.Movements;
using BookTraderExample.Assets;
using System;
using System.Collections.Generic;

namespace AssetExample.Wallets
{
    public class CommodityWalletStrategy : IWalletStrategy<CommodityMovement>
    {
        private readonly IList<Asset<CommodityMovement>> _commodityAssets = new List<Asset<CommodityMovement>>();

        public void AddAsset(Asset<CommodityMovement> asset)
        {
            asset.Id = Guid.NewGuid();
            _commodityAssets.Add(asset);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n[Commodity Wallet] New Asset was added. Please check the details.");
            Console.ForegroundColor = ConsoleColor.White;
            asset.PrintDetails();
        }
    }
}
