using AssetExample.Assets.Movements;
using AssetExamples.Assets;
using System;
using System.Collections.Generic;

namespace AssetExample.Wallets
{
    public class StockWalletStrategy : IWalletStrategy<StockMovement>
    {
        private readonly IList<Asset<StockMovement>> _stockAssets = new List<Asset<StockMovement>>();

        public void AddAsset(Asset<StockMovement> asset)
        {
            asset.Id = Guid.NewGuid();
            _stockAssets.Add(asset);

            CustomConsole.WriteLine("\n[Stock Wallet] New Asset was added. Please check the details.", ConsoleColor.DarkRed);
            asset.PrintDetails();
        }
    }
}
