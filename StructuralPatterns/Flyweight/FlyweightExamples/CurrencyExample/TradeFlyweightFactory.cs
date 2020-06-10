using System;
using System.Collections.Generic;

namespace CurrencyExample
{
    public class TradeFlyweightFactory
    {
        private Dictionary<Tuple<Guid, Guid>, Trade> _trades = 
            new Dictionary<Tuple<Guid, Guid>, Trade>();
        
        public TradeFlyweight GetTrade(Guid buyerId, Guid sellerId)
        {
            var key = Tuple.Create(buyerId, sellerId);

            var trade = _trades.GetValueOrDefault(key);

            if (trade != null)
            {
                Console.WriteLine($"\nReusing existing TradeFlyweight - BuyerId: {buyerId} - SellerId: {sellerId}");
                return trade;
            }

            Console.WriteLine($"\nCreating new TradeFlyweight - BuyerId: {buyerId} - SellerId: {sellerId}");
            trade = new Trade(buyerId, sellerId);
            _trades.Add(key, trade);

            return trade;
        }
    }
}