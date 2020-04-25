using System;
using System.Collections.Generic;
using System.Text;

namespace OrderBuilderExample.Orders.ValueObjects
{
    public class Movement
    {
        public DateTime WithdrawalDate { get; set; }
        public MovementDirection Direction { get; set; }
        public decimal Price { get; set; }
        public double Volume { get; set; }
        public Currency Currency { get; set; }
    }
}
