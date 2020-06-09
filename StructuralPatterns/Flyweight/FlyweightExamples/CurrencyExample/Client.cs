using System;

namespace CurrencyExample
{
    public class Client
    {
        private readonly TradeFactory _factory = new TradeFactory();

        public void BookTrade(
            Guid buyerId, Guid sellerId, CurrencyPairs currencyPair, decimal volume, decimal price, DateTime date)
        {
            var trade = _factory.GetTrade(buyerId, sellerId);

            var forexDetails = new ForexDetails(currencyPair, volume, price, date);

            trade.BookTrade(forexDetails);
        }
    }
}
