using AssetExample.Assets.Movements.ValueObjects;
using AssetExamples.Assets;
using AssetExamples.Assets.Movements;
using System;

namespace AssetExample.Assets.Movements
{
    public class StockMovement : Movement
    {
        protected readonly StockCode _stockCode;

        public StockMovement(DateTime withdrawDate, decimal price, StockCode stockCode, decimal volume)
            : base(withdrawDate, price, volume)
        {
            _stockCode = stockCode;
        }

        public override void PrintDetails()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Withdraw Date: {_withdrawDate.ToShortDateString()}");
            Console.WriteLine($"Volume: {_volume}");
            Console.WriteLine($"Price: $ {_price}");
            Console.WriteLine($"Stock COde: {_stockCode}");
        }
    }
}
