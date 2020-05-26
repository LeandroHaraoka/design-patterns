using ForexAssetsExample.ForexOperations;
using static ForexAssetsExample.ForexOperations.Direction;
using static ForexAssetsExample.ForexOperations.OptionType;

namespace ForexAssetsExample.Visitors
{
    public interface IPnlCalculusVisitor
    {
        decimal Visit(FxForwardContract fxForwardContract);
        decimal Visit(FxVanillaOption fxVanillaOption);
    }

    public class PnLCalculusVisitor : IPnlCalculusVisitor
    {
        private readonly decimal _spotRate;
        public PnLCalculusVisitor(decimal spotRate) => _spotRate = spotRate;

        public decimal Visit(FxForwardContract fxForwardContract)
        {
            var result = (_spotRate - fxForwardContract.Price) * fxForwardContract.Notional;

            return fxForwardContract.Direction == Sell ? -result : result;
        }

        public decimal Visit(FxVanillaOption fxVanillaOption)
        {
            var sellFactor = fxVanillaOption.Direction == Sell ? -1 : 1;

            // Business rules specify there are only these two options, that's why we're not worried about scalability now.
            if (fxVanillaOption.Type == Call) return CalculateCallOptionPnL(fxVanillaOption) * sellFactor;
            if (fxVanillaOption.Type == Put) return CalculatePutOptionPnL(fxVanillaOption) * sellFactor;
            return default;
        }

        private decimal CalculateCallOptionPnL(FxVanillaOption fxVanillaOption)
        {
            if (_spotRate <= fxVanillaOption.Strike)
                return -fxVanillaOption.Premium;

            return (_spotRate - fxVanillaOption.Strike) * fxVanillaOption.Notional - fxVanillaOption.Premium;
        }

        private decimal CalculatePutOptionPnL(FxVanillaOption fxVanillaOption)
        {
            if (_spotRate >= fxVanillaOption.Strike)
                return -fxVanillaOption.Premium;

            return (fxVanillaOption.Strike - _spotRate) * fxVanillaOption.Notional - fxVanillaOption.Premium;
        }
    }
}
