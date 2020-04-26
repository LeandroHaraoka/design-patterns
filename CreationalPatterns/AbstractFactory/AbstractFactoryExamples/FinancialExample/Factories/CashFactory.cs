using System;
using System.Collections.Generic;
using System.Text;
using FinancialExample.Aggregates.Deals;
using FinancialExample.Aggregates.Orders;

namespace FinancialExample.Factories
{
    public class CashFactory : FinancialFactory
    {
        public override Order CreateOrder()
        {
            return new CashOrder();
        }

        public override Deal CreateDeal()
        {
            return new CashDeal();
        }
    }
}
