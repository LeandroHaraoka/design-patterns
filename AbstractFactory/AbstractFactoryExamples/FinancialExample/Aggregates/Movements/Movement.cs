using FinancialExample.Aggregates.ValueTypes;
using System;

namespace FinancialExample.Aggregates.Movements
{
    public abstract class Movement
    {
        public DateTime WithdrawalDate { get; set; }
        public MovementDirection Direction { get; set; }
        public decimal Price { get; set; }
        public double Volume { get; set; }
        public Currency Currency { get; set; }
    }
}
