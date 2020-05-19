using System;
using static AssetManagementExample.Curves;

namespace AssetManagementExample.Accruals
{
    public static class FinancialOperations
    {
        public static decimal ApplyTax(decimal amount, decimal tax)
        {
            return amount * (1 + tax);
        }

        public static decimal Accrual(DateTime currentDate, decimal amount, decimal indexRate)
        {
            var DIValue = DICurve[currentDate];

            return ApplyTax(amount, indexRate * DIValue);
        }
    }
}
