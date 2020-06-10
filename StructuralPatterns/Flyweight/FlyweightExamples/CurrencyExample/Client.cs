using System;

namespace CurrencyExample
{
    public class Client
    {
        private readonly TradeFlyweightFactory _factory = new TradeFlyweightFactory();

        public void BookTrade(
            Guid buyerId, Guid sellerId, CurrencyPairs currencyPair, decimal volume, decimal price, DateTime date)
        {
            var trade = _factory.GetTrade(buyerId, sellerId);

            var tradeOperation = new TradeOperation(currencyPair, volume, price, date);

            trade.BookTrade(tradeOperation);
        }
    }
}
