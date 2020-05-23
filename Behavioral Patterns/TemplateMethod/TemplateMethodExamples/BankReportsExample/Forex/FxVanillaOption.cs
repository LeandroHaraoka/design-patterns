using System;

namespace BankReportsExample.Forex
{

    public class FxVanillaOption : FxOperation
    {
        private readonly double _premium;
        private readonly double _spot;
        private readonly double _strike;
        private readonly OptionType _type;
        private readonly ExecutionType _executiontype;

        public FxVanillaOption(DateTime tradedate, CurrencyPair currencypair, double notional,
            double premium, double spot, double strike, OptionType type, ExecutionType executiontype,
            Direction direction, DateTime withdrawdate, DateTime settlementdate)
            : base(tradedate, currencypair, notional, direction, withdrawdate, settlementdate)
        {
            _premium = premium;
            _spot = spot;
            _strike = strike;
            _type = type;
            _executiontype = executiontype;
        }

        public override void Print()
        {
            CustomConsole.PrintRow(_id.ToString(), _tradedate.ToShortDateString(), _currencypair.ToString(),
                _notional.ToString(), _premium.ToString(), _spot.ToString(), _strike.ToString(), _direction.ToString(),
                _type.ToString(), _executiontype.ToString(), _withdrawdate.ToShortDateString(), _settlementdate.ToShortDateString());
        }
    }
}
