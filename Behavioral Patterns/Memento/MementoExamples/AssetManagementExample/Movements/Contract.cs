using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementExample.Movements
{
    public class Contract
    {
        public decimal IndexRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime SettlementDate { get; set; }
    }
}
