using ForexAssetsExample.ForexOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForexAssetsExample.Visitors
{
    public interface IPnLDisplayVisitor
    {
        void Visit(FxForwardContract fxForwardContract);
        void Visit(FxVanillaOption fxVanillaOption);
    }

    public class PnLDisplayVisitor : IPnLDisplayVisitor
    {
        private readonly decimal _pnlValue;
        public PnLDisplayVisitor(decimal pnlValue) => _pnlValue = pnlValue;

        public void Visit(FxForwardContract fxForwardContract)
        {
            Console.WriteLine();
            CustomConsole.PrintRow("TradeDate", "Symbol", "Notional", "Price", "Buy/Sell", "WithdrawDate", "SettlementDate", "PnL");
            CustomConsole.PrintRow(fxForwardContract.Tradedate.ToShortDateString(), fxForwardContract.Currencypair.ToString(),
                fxForwardContract.Notional.ToString(), fxForwardContract.Price.ToString(), fxForwardContract.Direction.ToString(),
                fxForwardContract.Withdrawdate.ToShortDateString(), fxForwardContract.Settlementdate.ToShortDateString(), _pnlValue.ToString());
        }

        public void Visit(FxVanillaOption fxVanillaOption)
        {
            Console.WriteLine();
            CustomConsole.PrintRow("TradeDate", "Symbol", "Notional", "Premium", "Spot", "Strike", "Buy/Sell",
                "Call/Put", "Amer/Eur", "WithdrawDate", "SettlementDate", "PnL");
            CustomConsole.PrintRow(fxVanillaOption.Tradedate.ToShortDateString(), fxVanillaOption.Currencypair.ToString(),
                fxVanillaOption.Notional.ToString(), fxVanillaOption.Premium.ToString(), fxVanillaOption.Spot.ToString(),
                fxVanillaOption.Strike.ToString(), fxVanillaOption.Direction.ToString(), fxVanillaOption.Type.ToString(),
                fxVanillaOption.Executiontype.ToString(), fxVanillaOption.Withdrawdate.ToShortDateString(),
                fxVanillaOption.Settlementdate.ToShortDateString(), _pnlValue.ToString());
        }
    }
}
