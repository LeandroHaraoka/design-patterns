using System;
using System.Collections.Generic;
using System.Text;
using FinancialExample.Aggregates.Deals;
using FinancialExample.Aggregates.Orders;

namespace FinancialExample.Factories
{
    public class BondFactory : IFinancialFactory
    {
        public Order CreateOrder()
        {
            return new BondOrder();
        }

        public Deal CreateDeal()
        {
            return new BondDeal();
        }
    }
}
