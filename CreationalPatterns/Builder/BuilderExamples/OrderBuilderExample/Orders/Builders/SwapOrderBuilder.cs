using OrderBuilderExample.Orders.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderBuilderExample.Orders.Builders
{
    public class SwapOrderBuilder : IOrderBuilder
    {
        private Order _creditOrder;

        public IOrderBuilder BuildTradeDate()
        {
            _creditOrder.TradeDate = DateTime.UtcNow;
            return this;
        }

        public IOrderBuilder BuildCounterparty(string counterparty)
        {
            if (string.IsNullOrWhiteSpace(counterparty))
            {
                Console.WriteLine("Error: SwapOrder counterparty is invalid.");
                return this;
            }

            _creditOrder.Counterparty = counterparty;
            return this;
        }

        public IOrderBuilder BuildInstitution(string institution)
        {
            if (string.IsNullOrWhiteSpace(institution))
            {
                Console.WriteLine("Error: SwapOrder institution is invalid.");
                return this;
            }

            _creditOrder.Institution = institution;
            return this;
        }

        public IOrderBuilder BuildTrader(string trader)
        {
            if (string.IsNullOrWhiteSpace(trader))
            {
                Console.WriteLine("Error: SwapOrder trader is invalid.");
                return this;
            }

            _creditOrder.Trader = trader;
            return this;
        }

        public IOrderBuilder AddMovements(List<Movement> movements)
        {
            if (!movements.Any(m => m.Direction == MovementDirection.Inflow) &&
                !movements.Any(m => m.Direction == MovementDirection.Outflow))
                throw new ArgumentException("Error: SwapOrder must contain, at least, one inflow and one outflow movement.");

            _creditOrder.Movements.AddRange(movements);
            return this;
        }

        public Order Build()
        {
            Order bondOrder = _creditOrder;
            Reset();
            return bondOrder;
        }

        public void Reset()
        {
            _creditOrder = new Order();
        }
    }
}
