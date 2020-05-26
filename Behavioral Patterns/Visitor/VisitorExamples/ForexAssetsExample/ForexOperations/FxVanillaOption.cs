using ForexAssetsExample.Visitors;
using System;

namespace ForexAssetsExample.ForexOperations
{
    public class FxVanillaOption : FxOperation
    {
        public decimal Premium { get; set; }
        public decimal Spot { get; set; }
        public decimal Strike { get; set; }
        public OptionType Type { get; set; }
        public ExecutionType Executiontype { get; set; }

        public FxVanillaOption(DateTime tradedate, CurrencyPair currencypair, decimal notional,
            decimal premium, decimal spot, decimal strike, OptionType type, ExecutionType executiontype,
            Direction direction, DateTime withdrawdate, DateTime settlementdate)
            : base(tradedate, currencypair, notional, direction, withdrawdate, settlementdate)
        {
            Premium = premium;
            Spot = spot;
            Strike = strike;
            Type = type;
            Executiontype = executiontype;
        }

        public override decimal CalculatePnL(IPnlCalculusVisitor visitor) => visitor.Visit(this);

        public override void DisplayPnL(IPnLDisplayVisitor visitor) => visitor.Visit(this);
    }
}
