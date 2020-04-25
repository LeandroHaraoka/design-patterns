using OrderBuilderExample.Orders;
using OrderBuilderExample.Orders.Builders;
using OrderBuilderExample.Orders.Directors;
using OrderBuilderExample.Orders.ValueObjects;
using System;

namespace OrderBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder");
            Console.WriteLine("Order Builder Example");

            var cashOrderDirector = new CashOrderDirector();
            var cashOrderBuilder = new CashOrderBuilder();
            cashOrderDirector.SetBuilder(cashOrderBuilder);

            Console.WriteLine("\n[Citibank Empty Cash Order]");
            cashOrderDirector.BuildEmptyCitibankOrder();
            var cashOrder = cashOrderBuilder.Build();
            PrintResult(cashOrder);

            Console.WriteLine("\n[Citibank Deposit Order $ 1000.00]");
            cashOrderDirector.BuildCitibankDepositOrder(1000);
            var depositOrder = cashOrderBuilder.Build();
            PrintResult(depositOrder);

            var swapOrderDirector = new SwapOrderDirector();
            var swapOrderBuilder = new SwapOrderBuilder();
            swapOrderDirector.SetBuilder(swapOrderBuilder);
            
            Console.WriteLine("\n[Swap Order $ 2000.00 : $ 2050.00]");
            swapOrderDirector.BuildCreditOrder(2000, 2050, Currency.USD);
            var swapOrder = swapOrderBuilder.Build();
            PrintResult(swapOrder);
        }

        private static void PrintResult(Order order)
        {
            Console.WriteLine($"Order Counterparty: {order.Counterparty}");
            Console.WriteLine($"Order Institution: {order.Institution}");
            Console.WriteLine($"Order TradeDate: {order.TradeDate}");
            Console.WriteLine($"Order Movements Count: {order.Movements.Count}");

            foreach (var movement in order.Movements)
            {
                Console.WriteLine($"    Movement: {movement.Currency} {movement.Price}");
            }
        }
    }
}
