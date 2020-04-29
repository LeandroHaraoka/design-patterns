using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentOperationFactory.FinancialMath
{
    public static class CompoundInterest
    {
        public static decimal CalculateInterestAmount(decimal amount, decimal iterations, decimal annualInterestRate)
        {
            var grossAmount = amount;
            var dailyRate = RateConversion.FromAnnualToDaily(annualInterestRate);
            
            for (int i = 0; i < iterations; i++)
            {
                grossAmount *= (1 + dailyRate);
            }

            return grossAmount - amount;
        }
    }
}
