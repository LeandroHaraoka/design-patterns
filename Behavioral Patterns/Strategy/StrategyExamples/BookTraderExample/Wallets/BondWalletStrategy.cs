using AssetExample.Assets.Movements;
using BookTraderExample.Assets;
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n[Bond Wallet] New Asset was added. Please check the details.");
            Console.ForegroundColor = ConsoleColor.White;
            asset.PrintDetails();
        }
    }
}
