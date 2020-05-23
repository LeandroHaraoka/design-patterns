using AssetExample.Assets.Movements;
using static AssetExample.Assets.Movements.ValueObjects.BondIndex;
using static AssetExample.Assets.Movements.ValueObjects.CommodityIdentifier;
using static AssetExample.Assets.Movements.ValueObjects.Currencies;
using static AssetExample.Assets.Movements.ValueObjects.Direction;
using static AssetExample.Assets.Movements.ValueObjects.StockCode;
using AssetExamples.Assets;
using System;
using AssetExample.Wallets;

namespace AssetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy");
            Console.WriteLine("Asset Wallets Example\n");

            var buyerId = Guid.NewGuid();
            var sellerId = Guid.NewGuid();

            #region Create Assets
            var cashAsset = new Asset<CashMovement>(buyerId, sellerId, DateTime.Today, new CashWalletStrategy());
            cashAsset.AddMovement(new CashMovement(new DateTime(2020, 08, 15), 7000, Inflow, 1));

            var bondAsset = new Asset<BondMovement>(buyerId, sellerId, DateTime.Today, new BondWalletStrategy());
            bondAsset.AddMovement(new BondMovement(new DateTime(2020, 02, 18), 500, Inflow, 1));
            bondAsset.AddMovement(new BondMovement(new DateTime(2020, 12, 30), 500, Outflow, PRE, 0.3m, 1));

            var forexAsset = new Asset<ForexMovement>(buyerId, sellerId, DateTime.Today, new ForexWalletStrategy());
            forexAsset.AddMovement(new ForexMovement(new DateTime(2020, 12, 30), 16.5m, USD, BRL, 1000));

            var stockAsset = new Asset<StockMovement>(buyerId, sellerId, DateTime.Today, new StockWalletStrategy());
            stockAsset.AddMovement(new StockMovement(new DateTime(2020, 12, 30), 230m, FB, 100));

            var commodityAsset = new Asset<CommodityMovement>(buyerId, sellerId, DateTime.Today, new CommodityWalletStrategy());
            commodityAsset.AddMovement(new CommodityMovement(new DateTime(2020, 12, 30), 1750m, GOLD, 1));
            #endregion

            #region Add Assets to Wallets
            cashAsset.AddAssetToWallet();
            bondAsset.AddAssetToWallet();
            forexAsset.AddAssetToWallet();
            stockAsset.AddAssetToWallet();
            commodityAsset.AddAssetToWallet();
            #endregion
        }
    }
}
