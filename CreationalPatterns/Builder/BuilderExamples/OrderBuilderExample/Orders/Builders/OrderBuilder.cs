using OrderBuilderExample.Orders.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderBuilderExample.Orders.Builders
{
    public interface IOrderBuilder
    {
        IOrderBuilder BuildTradeDate();
        IOrderBuilder BuildCounterparty(string counterparty);
        IOrderBuilder BuildInstitution(string institution);
        IOrderBuilder BuildTrader(string trader);
        IOrderBuilder AddMovements(List<Movement> movements);
        Order Build();
        void Reset();
    }
}
