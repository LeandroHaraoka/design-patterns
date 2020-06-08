using HttpRequestExample.Facade;
using System;

namespace HttpRequestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facade");
            Console.WriteLine("HTTP Communication Example\n");

            var transaction = new Transaction(Guid.NewGuid(), Guid.NewGuid(), 1000, DateTime.UtcNow);
            var transactionSender = new TransactionSender();
            var transactionStatus = transactionSender.Send(transaction);
        }
    }
}
