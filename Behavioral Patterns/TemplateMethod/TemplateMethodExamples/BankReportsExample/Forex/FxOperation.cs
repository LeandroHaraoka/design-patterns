using System;

namespace BankReportsExample.Forex
{
    public abstract class FxOperation
    {
        protected Guid _id;
        protected readonly DateTime _tradedate;
        protected readonly CurrencyPair _currencypair;
        protected readonly double _notional;
        protected readonly Direction _direction;
        protected readonly DateTime _withdrawdate;
        protected readonly DateTime _settlementdate;

        protected FxOperation(DateTime tradedate, CurrencyPair currencypair, double notional, 
            Direction direction, DateTime withdrawdate, DateTime settlementdate)
        {
            _tradedate = tradedate;
            _currencypair = currencypair;
            _notional = notional;
            _direction = direction;
            _withdrawdate = withdrawdate;
            _settlementdate = settlementdate;
        }

        public void SetId(Guid id) => _id = id;

        public abstract void Print();
    }

    public enum CurrencyPair { EURUSD, USDBRL, USDCAD }
    public enum Direction { Buy, Sell }
    public enum OptionType { Call, Put }
    public enum ExecutionType { American, European }
}
