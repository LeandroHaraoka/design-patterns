using AssetExample.Assets.Movements.ValueObjects;
using AssetExamples.Assets;
using AssetExamples.Assets.Movements;
using System;

namespace AssetExample.Assets.Movements
{
    public class ForexMovement : Movement
    {
        protected readonly Currencies _referenceCurrency;
        protected readonly Currencies _currency;

        public ForexMovement(DateTime withdrawDate, decimal price, Currencies referenceCurrency, Currencies currency, decimal volume)
            : base(withdrawDate, price, volume)
        {
            _referenceCurrency = referenceCurrency;
            _currency = currency;
        }

        public override void PrintDetails()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Withdraw Date: {_withdrawDate.ToShortDateString()}");
            Console.WriteLine($"Volume: {_volume}");
            Console.WriteLine($"Price: {_price}");
            Console.WriteLine($"Ref. Currency: {_referenceCurrency}");
            Console.WriteLine($"Currency: {_currency}");
        }
    }
}
