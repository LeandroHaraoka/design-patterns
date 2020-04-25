using FinancialExample.Aggregates.Deals;
using FinancialExample.Aggregates.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialExample.Factories
{
    public interface IFinancialFactory
    {
        Order CreateOrder();
        Deal CreateDeal();
    }
}
