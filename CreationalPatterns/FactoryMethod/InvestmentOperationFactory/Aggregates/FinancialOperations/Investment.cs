using InvestmentOperationFactory.Aggregates.BondCredits.ValueObjects;
using InvestmentOperationFactory.FinancialMath;
using System;

namespace InvestmentOperationFactory.Aggregates.FinancialOperations
{
    public class Investment : FinancialOperation
    {
        public Investment(DateTime tradeDate, decimal amount, DateTime maturityDate, decimal interestRate, decimal taxes = 0)
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
            
            Console.WriteLine($"\nInvestment:");
            Console.WriteLine($"    TradeDate: {TradeDate.Date}");
            Console.WriteLine($"    Invested: {Amount}");
            Console.WriteLine($"    InterestRate: {InterestRate}");
            Console.WriteLine($"    MaturityDate: {MaturityDate.Date}");
            Console.WriteLine($"    FutureValue: {valueAtMaturity.GrossAmount}");
            Console.WriteLine($"    TaxAmount: {valueAtMaturity.TaxesAmount}");
        }
    }
}
