using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentOperationFactory.FinancialMath
{
    public static class RateConversion
    {
        public static decimal FromAnnualToDaily(decimal annualRate)
        {
            return MathExtensions.Pow(1m + annualRate, 1/360m) - 1;
        }
    }
}
