using InvestmentOperationFactory.Aggregates.BondCredits.ValueObjects;
using System;

namespace InvestmentOperationFactory.Aggregates.FinancialOperations
{
    public abstract class FinancialOperation
    {
        public decimal Amount { get; set; }
        public DateTime TradeDate { get; set; }
        public DateTime MaturityDate { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Taxes { get; set; }

        protected FinancialOperation(DateTime tradeDate, decimal amount, DateTime maturityDate, decimal interestRate, decimal taxes = 0)
        {
            TradeDate = tradeDate;
            Amount = amount;
            MaturityDate = maturityDate;
            InterestRate = interestRate;
            Taxes = taxes;
        }

        public abstract void PrintStatement();
    }
}
