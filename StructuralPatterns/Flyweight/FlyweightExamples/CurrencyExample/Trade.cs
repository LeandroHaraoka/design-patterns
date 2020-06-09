using System;

namespace CurrencyExample
{
    public class Trade
    {
        public Guid BuyerId { get; set; }
        public Guid SellerId { get; set; }
      
        public Trade(Guid buyerId, Guid sellerId)
        {
            BuyerId = buyerId;
            SellerId = sellerId;
        }

        public void BookTrade(ForexDetails forexDetails)
        {
            Console.WriteLine("\nNew Order Booked.");
            Console.WriteLine($"Trade Date: {forexDetails.TradeDate.ToShortDateString()}");
            Console.WriteLine($"Buyer Id: {BuyerId}");
            Console.WriteLine($"Seller Id: {SellerId}");
            Console.WriteLine($"CCY1/CCY2: {forexDetails.CurrencyPair}");
            Console.WriteLine($"Volume: {forexDetails.Volume}");
            Console.WriteLine($"Price: {forexDetails.Price}");
        }
    }
}
