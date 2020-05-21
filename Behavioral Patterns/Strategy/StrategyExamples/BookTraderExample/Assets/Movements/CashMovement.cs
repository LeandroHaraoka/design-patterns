using AssetExample.Assets.Movements.ValueObjects;
using BookTraderExample.Assets;
using BookTraderExample.Assets.Movements;
using System;

namespace AssetExample.Assets.Movements
{
    public class CashMovement : Movement
    {
        protected readonly Direction _direction;

        public CashMovement(DateTime withdrawDate, decimal price, Direction direction, decimal volume)
            : base(withdrawDate, price, volume)
        {
            _direction = direction;
        }

        public override void PrintDetails()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Withdraw Date: {_withdrawDate.ToShortDateString()}");
            Console.WriteLine($"Volume: {_volume}");
            Console.WriteLine($"Price: $ {_price}");
            Console.WriteLine($"Direction: {_direction}");
        }
    }
}
