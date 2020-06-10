using System;

namespace CurrencyExample
{
    public class Trade : TradeFlyweight
    {
        public Guid BuyerId { get; set; }
        public Guid SellerId { get; set; }
      
        public Trade(Guid buyerId, Guid sellerId)
        {
            BuyerId = buyerId;
            SellerId = sellerId;
        }

        public override void BookTrade(TradeOperation tradeOperation)
        {
            Console.WriteLine("\nNew Order Booked.");
            Console.WriteLine($"Trade Date: {tradeOperation.TradeDate.ToShortDateString()}");
            Console.WriteLine($"Buyer Id: {BuyerId}");
            Console.WriteLine($"Seller Id: {SellerId}");
            Console.WriteLine($"CCY1/CCY2: {tradeOperation.CurrencyPair}");
            Console.WriteLine($"Volume: {tradeOperation.Volume}");
            Console.WriteLine($"Price: {tradeOperation.Price}");
            tradeOperation.Booked = true;
        }
    }
}
