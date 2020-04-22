using FinancialExample.Aggregates.Movements;
using System;
using System.Collections.Generic;

namespace FinancialExample.Aggregates.Orders
{
    public abstract class Order
    {
        public Guid Id { get; set; }
        public DateTime TradeDate { get; set; }
        public string Counterparty { get; set; }
        public string Institution { get; set; }
        public string Trader { get; set; }
        public List<Movement> Movements { get; set; }
    }
}
