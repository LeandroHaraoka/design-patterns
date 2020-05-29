using System;

namespace LegacyCodesExample.Adapters
{
    public interface IComplexFinancialCalculus
    {
        decimal Calculate(decimal amount, decimal rate, DateTime initialDate, DateTime finalDate);
    }
}
