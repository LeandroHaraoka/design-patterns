using System;
using System.Collections.Generic;
using System.Text;
using FinancialExample.Aggregates.Deals;
using FinancialExample.Aggregates.Orders;

namespace FinancialExample.Factories
{
    public class BondFactory : FinancialFactory
    {
        public override Order CreateOrder()
        {
            return new BondOrder();
        }

        public override Deal CreateDeal()
        {
            return new BondDeal();
        }
    }
}
