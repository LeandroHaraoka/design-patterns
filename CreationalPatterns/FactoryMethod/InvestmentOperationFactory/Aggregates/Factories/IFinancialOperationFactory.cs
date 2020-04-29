using InvestmentOperationFactory.Aggregates.BondCredits;
using InvestmentOperationFactory.Aggregates.FinancialOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentOperationFactory.Aggregates.Factories
{
    public interface IFinancialOperationFactory
    {
        FinancialOperation CreateInvestment(decimal amount, DateTime maturityDate, decimal interestRate);
        FinancialOperation CreateRetrieval(decimal amount, DateTime maturityDate, decimal interestRate);
    }
}
