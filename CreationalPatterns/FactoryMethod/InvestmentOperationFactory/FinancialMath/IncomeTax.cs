using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvestmentOperationFactory.FinancialMath
{
    public static class IncomeTax
    {
        private static Dictionary<int, decimal> _incomeTaxByPeriod =
            new Dictionary<int, decimal>
            {
                        {   0, 0.225m },
                        { 180, 0.200m },
                        { 360, 0.175m },
                        { 720, 0.150m }
            };

        public static decimal Get(int days)
        {
            var periodsCollection = _incomeTaxByPeriod.Keys.ToList();

            var period = periodsCollection.Where(p => p < days).Max();

            return _incomeTaxByPeriod[period];
        }
    }
}
