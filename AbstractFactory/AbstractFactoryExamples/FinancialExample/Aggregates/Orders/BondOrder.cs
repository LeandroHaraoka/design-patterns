using System;

namespace FinancialExample.Aggregates.Orders
{
    public class BondOrder : Order
    {
        public DateTime MaturityDate { get; set; }
        public string IsinCode { get; set; }
    }
}
