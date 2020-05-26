using ForexAssetsExample.Visitors;
using System;

namespace ForexAssetsExample.ForexOperations
{
    public abstract class FxOperation
    {
        public DateTime Tradedate { get; set; }
        public CurrencyPair Currencypair { get; set; }
        public decimal Notional { get; set; }
        public Direction Direction { get; set; }
        public DateTime Withdrawdate { get; set; }
        public DateTime Settlementdate { get; set; }

        protected FxOperation(DateTime tradedate, CurrencyPair currencypair, decimal notional, 
            Direction direction, DateTime withdrawdate, DateTime settlementdate)
        {
            Tradedate = tradedate;
            Currencypair = currencypair;
            Notional = notional;
            Direction = direction;
            Withdrawdate = withdrawdate;
            Settlementdate = settlementdate;
        }

        public abstract decimal CalculatePnL(IPnlCalculusVisitor visitor);
        public abstract void DisplayPnL(IPnLDisplayVisitor visitor);
    }

    public enum CurrencyPair { EURUSD, USDBRL, USDCAD }
    public enum Direction { Buy, Sell }
    public enum OptionType { Call, Put }
    public enum ExecutionType { American, European }
}
