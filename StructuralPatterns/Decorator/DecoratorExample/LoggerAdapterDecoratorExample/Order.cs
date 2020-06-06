using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerAdapterDecoratorExample
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Product { get; set; }
        public string Buyer { get; set; }
        public string Seller { get; set; }
        public decimal Price { get; set; }
        public decimal Volume { get; set; }

        public Order(Guid id, string product, string buyer, string seller, decimal price, decimal volume)
        {
            Id = id;
            Product = product;
            Buyer = buyer;
            Seller = seller;
            Price = price;
            Volume = volume;
        }
    }
}
