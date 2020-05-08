using FashionShopExample.Discounts;
using FashionShopExample.Items;
using System;
using System.Diagnostics;
using System.Threading;

namespace FashionShopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of Responsibility");
            Console.WriteLine("Fashion Shop Example");

            var discountApplier = new DiscountApplier();
            AddDiscounts(discountApplier);

            var shirt = new Shirt(discountApplier, 10m);
            var jeans = new Jeans(discountApplier, 30m);
            var sunglasses = new Sunglasses(discountApplier, 35m);

            PrintPrice();

            void PrintPrice()
            {
                var sw = new Stopwatch();
                sw.Start();

                while (sw.ElapsedMilliseconds < 20000)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine($"\r{shirt._name} price: $ {shirt.Price}  ");
                    Console.WriteLine($"\r{jeans._name} price: $ {jeans.Price}  ");
                    Console.WriteLine($"\r{sunglasses._name} price: $ {sunglasses.Price}  ");

                    Thread.Sleep(500);
                }
                sw.Stop();
            }
        }

        private static void AddDiscounts(DiscountApplier discountApplier)
        {
            var firstPurchaseDiscount = new FirstPurchaseDiscount(discountApplier);
            firstPurchaseDiscount.Add();

            var flashSale = new FlashSale(discountApplier, 5000);
            flashSale.Add();

            var dailySale = new DailySale(discountApplier);
            dailySale.Add();
        }


    }
}
