using OrderBuilderExample.Orders.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderBuilderExample.Orders.Builders
{
    public class CashOrderBuilder : IOrderBuilder
    {
        private Order _cashOrder;

        public IOrderBuilder BuildTradeDate()
        {
            _cashOrder.TradeDate = DateTime.UtcNow;
            return this;
        }

        public IOrderBuilder BuildCounterparty(string counterparty)
        {
            if (string.IsNullOrWhiteSpace(counterparty))
            {
                Console.WriteLine("Error: CashOrder counterparty is invalid.");
                return this;
            }

            _cashOrder.Counterparty = counterparty;
            return this;
        }

        public IOrderBuilder BuildInstitution(string institution)
        {
            if (string.IsNullOrWhiteSpace(institution))
            {
                Console.WriteLine("Error: CashOrder institution is invalid.");
                return this;
            }

            _cashOrder.Institution = institution;
            return this;
        }

        public IOrderBuilder BuildTrader(string trader)
        {
            if (string.IsNullOrWhiteSpace(trader))
            {
                Console.WriteLine("Error: CashOrder trader is invalid.");
                return this;
            }

            _cashOrder.Trader = trader;
            return this;
        }

        public IOrderBuilder AddMovements(List<Movement> movements)
        {
            _cashOrder.Movements.AddRange(movements);
            return this;
        }

        public Order Build()
        {
            Order cashOrder = _cashOrder;
            Reset();
            return cashOrder;
        }

        public void Reset()
        {
            _cashOrder = new Order();
        }
    }
}
