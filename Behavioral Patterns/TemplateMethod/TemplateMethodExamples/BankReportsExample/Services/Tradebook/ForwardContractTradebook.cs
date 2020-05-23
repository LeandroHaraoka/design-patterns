using BankReportsExample.Forex;
using System.Collections.Generic;

namespace BankReportsExample.Services.Notification
{
    public class ForwardContractTradebook
    {
        public void AddRange(List<FxOperation> fxOperations)
        {
            PrintHeader();
            fxOperations.ForEach(o => o.Print());
        }

        private void PrintHeader()
        {
            CustomConsole.PrintLine();
            CustomConsole.PrintRow("TradeId", "TradeDate", "Symbol", "Notional", "Price", "Buy/Sell", "WithdrawDate", "SettlementDate");
            CustomConsole.PrintLine();
        }
    }
}
