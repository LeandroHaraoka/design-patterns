using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockExample.StockQuotations
{
    public static class Notifications
    {
        public static void NotifyQuotation(StockQuotation quotation)
        {
            PrintDetailInYellow($"\n[{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")}] Quotation published", string.Empty);
            PrintDetailInYellow("Owner", quotation._ownerName);
            PrintDetailInYellow("Stock Identifier", quotation._stockIdentifier);
            PrintDetailInYellow("Bid/Ask", quotation._type);
            PrintDetailInYellow("Shares", quotation._stockShares);
            PrintDetailInYellow("Price", quotation._price);
        }

        public static void NotifyTransaction(StockQuotation myQuotation, StockQuotation arrivedQuotation)
        {
            var (seller, buyer) = myQuotation._type == QuotationType.Ask
                ? (myQuotation._ownerName, arrivedQuotation._ownerName)
                : (arrivedQuotation._ownerName, myQuotation._ownerName);

            PrintDetailInGreen($"\n[{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")}] Transaction executed", string.Empty);
            PrintDetailInGreen("Buyer", buyer);
            PrintDetailInGreen("Seller", seller);
            PrintDetailInGreen("Stock Identifier", myQuotation._stockIdentifier);
            PrintDetailInGreen("Shares", myQuotation._stockShares);
            PrintDetailInGreen("Price", myQuotation._price);
        }

        private static void CreateNotification(
            string notificationType, string buyer, string seller, StockIdentifier stockIdentifier, int shares, decimal price)
        {
            PrintDetailInGreen($"\n[{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")}] {notificationType} executed", string.Empty);
            PrintDetailInGreen("Buyer", buyer);
            PrintDetailInGreen("Seller", seller);
            PrintDetailInGreen("Stock Identifier", stockIdentifier);
            PrintDetailInGreen("Shares", shares);
            PrintDetailInGreen("Price", price);
        }


        private static void PrintDetail(ConsoleColor titleColor, string name, object info)
        {
            Console.ForegroundColor = titleColor;
            Console.Write($"{name}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($": {info}");
        }

        private static void PrintDetailInGreen(string name, object info)
        {
            PrintDetail(ConsoleColor.Green, name, info);
        }

        private static void PrintDetailInYellow(string name, object info)
        {
            PrintDetail(ConsoleColor.Yellow, name, info);
        }
    }
}
