using AssetExample.Assets.Movements.ValueObjects;
using AssetExamples.Assets;
using AssetExamples.Assets.Movements;
using System;

namespace AssetExample.Assets.Movements
{
    public class BondMovement : Movement
    {
        protected readonly Direction _direction;
        protected readonly BondIndex _index;
        protected readonly decimal? _rate;

        public BondMovement(DateTime withdrawDate, decimal price, Direction direction, decimal volume)
            : base(withdrawDate, price, volume)
        {
            _direction = direction;
            _index = BondIndex.Undefined;
            _rate = null;
        }

        public BondMovement(DateTime withdrawDate, decimal price, Direction direction, BondIndex index, decimal rate, decimal volume) 
            : base(withdrawDate, price, volume)
        {
            _direction = direction;
            _index = index;
            _rate = rate;
        }

        public override void PrintDetails()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Withdraw Date: {_withdrawDate.ToShortDateString()}");
            Console.WriteLine($"Volume: {_volume}");
            Console.WriteLine($"Price: $ {_price}");
            Console.WriteLine($"Direction: {_direction}");

            if (_index == BondIndex.Undefined)
                return;

            Console.WriteLine($"Index: {_index}");
            Console.WriteLine($"Rate: {_rate}");
        }
    }
}
