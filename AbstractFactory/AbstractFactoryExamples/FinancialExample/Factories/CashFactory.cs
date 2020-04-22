using System;
using System.Collections.Generic;
using System.Text;
using FinancialExample.Aggregates.Deals;
using FinancialExample.Aggregates.Orders;

namespace FinancialExample.Factories
{
    public class CashFactory : IFinancialFactory
    {
        public Order CreateOrder()
        {
            return new CashOrder();
        }

        public Deal CreateDeal()
        {
            return new CashDeal();
        }

    }
}
