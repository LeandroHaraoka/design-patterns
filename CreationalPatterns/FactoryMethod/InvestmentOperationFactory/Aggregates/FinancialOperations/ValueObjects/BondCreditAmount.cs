using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentOperationFactory.Aggregates.BondCredits.ValueObjects
{
    public struct ValueAtMaturity
    {
        public decimal GrossAmount { get; set; }
        public decimal TaxesAmount { get; set; }

        public ValueAtMaturity(decimal grossAmount, decimal taxesAmount)
        {
            GrossAmount = grossAmount;
            TaxesAmount = taxesAmount;
        }
    }
}
