using LegacyCodesExample.Legacy;
using System;

namespace LegacyCodesExample.Adapters
{
    public class ComplexFinancialCalculusAdapter : IComplexFinancialCalculus
    {
        public decimal Calculate(decimal amount, decimal rate, DateTime initialDate, DateTime finalDate)
            => ComplexFinancialCalculus.Calculate(amount, rate, initialDate, finalDate);
    }
}
