using InvestmentOperationFactory.Aggregates.BondCredits;
using InvestmentOperationFactory.Aggregates.FinancialOperations;
using System;

namespace InvestmentOperationFactory.Aggregates.Factories
{
    public class NoTaxesFinancialOperationFactory : IFinancialOperationFactory
    {
        public FinancialOperation CreateInvestment(decimal amount, DateTime maturityDate, decimal interestRate)
        {
            return new Investment(DateTime.Today, amount, maturityDate, interestRate);
        }

        public FinancialOperation CreateRetrieval(decimal amount, DateTime maturityDate, decimal interestRate)
        {
            return new Retrieval(DateTime.Today, amount, maturityDate, interestRate);
        }
    }
}
