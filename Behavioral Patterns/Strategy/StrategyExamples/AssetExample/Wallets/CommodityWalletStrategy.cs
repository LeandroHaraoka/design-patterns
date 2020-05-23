using AssetExample.Assets.Movements;
using AssetExamples.Assets;
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

            CustomConsole.WriteLine("\n[Commodity Wallet] New Asset was added. Please check the details.", ConsoleColor.Yellow);
            asset.PrintDetails();
        }
    }
}
