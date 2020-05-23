using System;

namespace BankReportsExample.Forex
{
    public class FxForwardContract : FxOperation
    {
        private readonly double _price;
        public FxForwardContract(DateTime tradedate, CurrencyPair currencypair, double notional, 
            double price, Direction direction, DateTime withdrawdate, DateTime settlementdate) 
            : base(tradedate, currencypair, notional, direction, withdrawdate, settlementdate)
        {
            _price = price;
        }

        public override void Print()
        {
            CustomConsole.PrintRow(_id.ToString(), _tradedate.ToShortDateString(), _currencypair.ToString(), 
                _notional.ToString(), _price.ToString(), _direction.ToString(), 
                _withdrawdate.ToShortDateString(), _settlementdate.ToShortDateString());
        }
    }
}
