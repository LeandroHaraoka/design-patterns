using AssetExample.Wallets;
using AssetExamples.Assets.Movements;
using System;
using System.Collections.Generic;

namespace AssetExamples.Assets
{
    public class Asset<TMovement> where TMovement : Movement
    {
        public Guid Id { get; set; }
        private readonly string _assetType;
        private readonly Guid _buyer;
        private readonly Guid _seller;
        private readonly DateTime _tradeDate;
        private readonly IList<TMovement> _movements = new List<TMovement>();
        private readonly IWalletStrategy<TMovement> _walletStrategy;

        public Asset(Guid buyer, Guid seller, DateTime tradeDate, IWalletStrategy<TMovement> walletStrategy)
        {
            _assetType = typeof(TMovement).Name.Replace(nameof(Movement), string.Empty);
            _buyer = buyer;
            _seller = seller;
            _tradeDate = tradeDate;
            _walletStrategy = walletStrategy;
        }

        public void AddMovement(TMovement movement) => _movements.Add(movement);

        public void AddAssetToWallet() => _walletStrategy.AddAsset(this);

        public void PrintDetails()
        {
            Console.WriteLine($"\nId: {Id}");
            Console.WriteLine($"Trade Date: {_tradeDate}");
            Console.WriteLine($"Asset Type: {_assetType}");
            Console.WriteLine($"Buyer Id: {_buyer}");
            Console.WriteLine($"Seller Id: {_seller}");

            foreach (var mov in _movements)
                mov.PrintDetails();
        }
    }
}
