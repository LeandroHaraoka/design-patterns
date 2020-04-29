using InvestmentOperationFactory.Aggregates.BondCredits.ValueObjects;
using InvestmentOperationFactory.Aggregates.FinancialOperations;
using InvestmentOperationFactory.FinancialMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentOperationFactory.Aggregates.BondCredits
{
    public class Retrieval : FinancialOperation
    {
        public Retrieval(DateTime tradeDate, decimal amount, DateTime maturityDate, decimal interestRate, decimal taxes = 0)
            : base(tradeDate, amount, maturityDate, interestRate, taxes)
        {
        }

        private ValueAtMaturity GetValueAtMaturity()
        {
            var days = (MaturityDate - TradeDate).Days;

            var interest = CompoundInterest.CalculateInterestAmount(Amount, days, InterestRate);

            var taxesAmount = interest * Taxes;

            return new ValueAtMaturity(Amount + interest, taxesAmount);
        }

        public override void PrintStatement()
        {
            var valueAtMaturity = GetValueAtMaturity();

            Console.WriteLine($"\nRetrieval:");
            Console.WriteLine($"    TradeDate: {TradeDate.Date}");
            Console.WriteLine($"    Retrieved: {Amount}");
            Console.WriteLine($"    InterestRate: {InterestRate}");
            Console.WriteLine($"    MaturityDate: {MaturityDate.Date}");
            Console.WriteLine($"    FutureValue: {valueAtMaturity.GrossAmount}");
            Console.WriteLine($"    TaxAmount: {valueAtMaturity.TaxesAmount}");
        }
    }
}
