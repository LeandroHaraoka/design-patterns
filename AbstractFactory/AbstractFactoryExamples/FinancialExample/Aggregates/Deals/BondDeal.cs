using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialExample.Aggregates.Deals
{
    public class BondDeal : Deal
    {
        public DateTime MaturityDate { get; set; }
        public string IsinCode { get; set; }
    }
}
