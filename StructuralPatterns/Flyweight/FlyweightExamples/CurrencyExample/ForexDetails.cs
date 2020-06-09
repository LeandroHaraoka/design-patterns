using System;

namespace CurrencyExample
{
    public class ForexDetails
    {
        public CurrencyPairs CurrencyPair { get; set; }
        public decimal Volume { get; set; }
        public decimal Price { get; set; }
        public DateTime TradeDate { get; set; }

        public ForexDetails(CurrencyPairs currencyPair, decimal volume, decimal price, DateTime tradeDate)
        {
            CurrencyPair = currencyPair;
            Volume = volume;
            Price = price;
            TradeDate = tradeDate;
        }
    }

    public enum CurrencyPairs { USDBRL, USDJPY, EURUSD, USDCAD }
}
