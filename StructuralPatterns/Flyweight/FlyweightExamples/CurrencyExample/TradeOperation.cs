using System;

namespace CurrencyExample
{
    public class TradeOperation
    {
        public CurrencyPairs CurrencyPair { get; set; }
        public decimal Volume { get; set; }
        public decimal Price { get; set; }
        public DateTime TradeDate { get; set; }
        public bool Booked { get; set; }

        public TradeOperation(CurrencyPairs currencyPair, decimal volume, decimal price, DateTime tradeDate)
        {
            CurrencyPair = currencyPair;
            Volume = volume;
            Price = price;
            TradeDate = tradeDate;
        }
    }

    public enum CurrencyPairs { USDBRL, USDJPY, EURUSD, USDCAD }
}
