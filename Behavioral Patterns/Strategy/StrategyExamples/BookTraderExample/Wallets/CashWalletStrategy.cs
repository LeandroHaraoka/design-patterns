using AssetExample.Assets.Movements;
using BookTraderExample.Assets;
using System;
using System.Collections.Generic;

namespace AssetExample.Wallets
{
    public class CashWalletStrategy : IWalletStrategy<CashMovement>
    {
        private readonly IList<Asset<CashMovement>> _cashAssets = new List<Asset<CashMovement>>();

        public void AddAsset(Asset<CashMovement> asset)
        {
            asset.Id = Guid.NewGuid();
            _cashAssets.Add(asset);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[Cash Wallet] New Asset was added. Please check the details.");
            Console.ForegroundColor = ConsoleColor.White;
            asset.PrintDetails();
        }
    }
}
