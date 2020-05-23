using AssetExample.Assets.Movements;
using AssetExamples.Assets;
using System;
using System.Collections.Generic;

namespace AssetExample.Wallets
{
    public class BondWalletStrategy : IWalletStrategy<BondMovement>
    {
        private readonly IList<Asset<BondMovement>> _bondAssets = new List<Asset<BondMovement>>();

        public void AddAsset(Asset<BondMovement> asset)
        {
            asset.Id = Guid.NewGuid();
            _bondAssets.Add(asset);
            
            CustomConsole.WriteLine("\n[Bond Wallet] New Asset was added. Please check the details.", ConsoleColor.Blue);
            asset.PrintDetails();
        }
    }
}
