using System;

namespace OrderApprovalExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy");
            Console.WriteLine("Order Approval Example\n");

            var orderWithProxy = CreateOrderWithProxy();

            var readerUser = new Member(Guid.NewGuid(), "Reader User", Role.Reader);
            orderWithProxy.Approve(readerUser);

            var readerWriterUser = new Member(Guid.NewGuid(), "Reader/Writer User", Role.ReaderWriter);
            orderWithProxy.Approve(readerWriterUser);
        }

        private static IOrder CreateOrderWithProxy()
        {
            var order = new Order(2m, 100m, "Product");
            return new OrderProxy(order);
        }
    }
}
