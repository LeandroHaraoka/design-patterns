using AssetExample.Assets.Movements;
using AssetExamples.Assets;
using System;
using System.Collections.Generic;

namespace AssetExample.Wallets
{
    public class ForexWalletStrategy : IWalletStrategy<ForexMovement>
    {
        private readonly IList<Asset<ForexMovement>> _forexAssets = new List<Asset<ForexMovement>>();

        public void AddAsset(Asset<ForexMovement> asset)
        {
            asset.Id = Guid.NewGuid();
            _forexAssets.Add(asset);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n[Forex Wallet] New Asset was added. Please check the details.");
            Console.ForegroundColor = ConsoleColor.White;
            asset.PrintDetails();
        }
    }
}
