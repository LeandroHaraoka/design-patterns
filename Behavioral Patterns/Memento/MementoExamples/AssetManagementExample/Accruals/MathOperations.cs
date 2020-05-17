using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementExample.Accruals
{
    public static class MathOperations
    {
        public static decimal ApplyTax(decimal amount, decimal tax)
        {
            return amount * (1 + tax);
        }
    }
}
