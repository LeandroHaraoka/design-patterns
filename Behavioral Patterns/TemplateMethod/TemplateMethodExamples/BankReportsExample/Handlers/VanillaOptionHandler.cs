using BankReportsExample.Forex;
using BankReportsExample.Services.Notification;
using BankReportsExample.Services.ReportReader;
using System.Collections.Generic;

namespace BankReportsExample.Handlers
{
    public class VanillaOptionHandler : ForexHandler
    {
        protected override List<FxOperation> ReadReport()
        {
            var optionsReader = new VanillaOptionReader();
            return optionsReader.ReadReport();
        }

        protected override void AddOperationsToTradebook(List<FxOperation> fxOperations)
        {
            var optionTradebook = new VanillaOptionTradebook();
            optionTradebook.Notify(fxOperations);
        }
    }
}
