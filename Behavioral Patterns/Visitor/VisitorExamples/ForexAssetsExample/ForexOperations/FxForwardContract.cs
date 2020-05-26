using ForexAssetsExample.Visitors;
using System;

namespace ForexAssetsExample.ForexOperations
{
    public class FxForwardContract : FxOperation
    {
        public decimal Price{ get; private set; }

        public FxForwardContract(DateTime tradedate, CurrencyPair currencypair, decimal notional, 
            decimal price, Direction direction, DateTime withdrawdate, DateTime settlementdate) 
            : base(tradedate, currencypair, notional, direction, withdrawdate, settlementdate)
        {
            Price = price;
        }

        public override decimal CalculatePnL(IPnlCalculusVisitor visitor) => visitor.Visit(this);
        public override void DisplayPnL(IPnLDisplayVisitor visitor) => visitor.Visit(this);
    }
}
