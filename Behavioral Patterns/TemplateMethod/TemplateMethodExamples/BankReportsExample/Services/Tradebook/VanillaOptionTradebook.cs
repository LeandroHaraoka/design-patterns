using BankReportsExample.Forex;
using System.Collections.Generic;

namespace BankReportsExample.Services.Notification
{
    public class VanillaOptionTradebook
    {
        public void Notify(List<FxOperation> fxOperations)
        {
            PrintHeader();
            fxOperations.ForEach(o => o.Print());
        }

        public void PrintHeader()
        {
            CustomConsole.PrintLine();
            CustomConsole.PrintRow("TradeId", "TradeDate", "Symbol", "Notional", "Premium", "Spot", "Strike", "Buy/Sell",
                "Call/Put", "Amer/Eur", "WithdrawDate", "SettlementDate");
            CustomConsole.PrintLine();
        }
    }
}
