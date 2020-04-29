using InvestmentOperationFactory.Aggregates.BondCredits;
using InvestmentOperationFactory.Aggregates.FinancialOperations;
using InvestmentOperationFactory.FinancialMath;
using System;

namespace InvestmentOperationFactory.Aggregates.Factories
{
    public class TaxedFinancialOperationFactory : IFinancialOperationFactory
    {
        public FinancialOperation CreateInvestment(decimal amount, DateTime maturityDate, decimal interestRate)
        {
            var tradeDate = DateTime.Today;
            var taxes = IncomeTax.Get((maturityDate - tradeDate).Days);
            
            return new Investment(tradeDate, amount, maturityDate, interestRate, taxes);
        }

        public FinancialOperation CreateRetrieval(decimal amount, DateTime maturityDate, decimal interestRate)
        {
            var tradeDate = DateTime.Today;
            var taxes = IncomeTax.Get((maturityDate - tradeDate).Days);

            return new Retrieval(tradeDate, amount, maturityDate, interestRate, taxes);
        }
    }
}
