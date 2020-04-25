using FinancialExample.Aggregates.Movements;
using System;
using System.Collections.Generic;

namespace FinancialExample.Aggregates.Deals
{
    public abstract class Deal
    {
        public DateTime OrderId { get; set; }
        public string Counterparty { get; set; }
        public string Institution { get; set; }
        public string Trader { get; set; }
        public List<Movement> Movements { get; set; }
    }
}
