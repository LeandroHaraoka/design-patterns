using BankReportsExample.Forex;
using BankReportsExample.Services.Notification;
using BankReportsExample.Services.ReportReader;
using System.Collections.Generic;

namespace BankReportsExample.Handlers
{
    public class ForwardContractHandler : ForexHandler
    {
        protected override List<FxOperation> ReadReport()
        {
            var forwardsReader = new ForwardContractReader();
            return forwardsReader.ReadReport();
        }

        protected override void AddOperationsToTradebook(List<FxOperation> fxOperations)
        {
            var forwardTradebook = new ForwardContractTradebook();
            forwardTradebook.AddRange(fxOperations);
        }
    }
}
