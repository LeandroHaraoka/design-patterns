using OrderBuilderExample.Orders.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderBuilderExample.Orders
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime TradeDate { get; set; }
        public string Counterparty { get; set; }
        public string Institution { get; set; }
        public string Trader { get; set; }
        public List<Movement> Movements { get; set; } = new List<Movement>();
    }
}
