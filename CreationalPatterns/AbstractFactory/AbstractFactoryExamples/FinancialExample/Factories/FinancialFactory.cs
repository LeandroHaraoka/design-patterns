using FinancialExample.Aggregates.Deals;
using FinancialExample.Aggregates.Orders;
using FinancialExample.Aggregates.ValueTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialExample.Factories
{
    public abstract class FinancialFactory
    {
        public static FinancialFactory GetFactory(AssetType assetType)
        {
            switch (assetType)
            {
                case AssetType.Cash: return new CashFactory();
                case AssetType.Bond: return new BondFactory();
                default: throw new ArgumentException("Please provide a valid asset type.");
            }
        }

        public abstract Order CreateOrder();
        public abstract Deal CreateDeal();
    }
}
