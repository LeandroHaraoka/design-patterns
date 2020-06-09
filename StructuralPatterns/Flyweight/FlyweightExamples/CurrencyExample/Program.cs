using System;

namespace CurrencyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flyweight");
            Console.WriteLine("Currency Example");

            var buyerId = Guid.NewGuid();
            var sellerId = Guid.NewGuid();

            var client = new Client();

            client.BookTrade(buyerId, sellerId, CurrencyPairs.USDBRL, 100m, 4.85m, DateTime.Today);

            client.BookTrade(buyerId, sellerId, CurrencyPairs.EURUSD, 50m, 1.13m, DateTime.Today.AddDays(-1));
            
            client.BookTrade(buyerId, sellerId, CurrencyPairs.USDJPY, 75m, 108.04m, DateTime.Today.AddDays(-2));
        }
    }
}
