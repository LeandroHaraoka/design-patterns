using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentOperationFactory.FinancialMath
{
    public static class MathExtensions
    {
        public static decimal Pow(decimal x, decimal y)
        {
            var asDoubleX = Convert.ToDouble(x);
            var asDoubleY = Convert.ToDouble(y);

            var result = Math.Pow(asDoubleX, asDoubleY);
            var asDecimalResult = Convert.ToDecimal(result);

            return asDecimalResult;
        }
    }
}
