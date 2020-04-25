using OrderBuilderExample.Orders.Builders;
using OrderBuilderExample.Orders.ValueObjects;
using System.Collections.Generic;

namespace OrderBuilderExample.Orders.Directors
{
    public class CashOrderDirector
    {
        private IOrderBuilder _orderBuilder;

        public void SetBuilder(IOrderBuilder orderBuilder)
        {
            orderBuilder.Reset();
            _orderBuilder = orderBuilder;
        }

        public IOrderBuilder BuildEmptyCitibankOrder()
        {
            return _orderBuilder
                .BuildTradeDate()
                .BuildCounterparty("Citibank")
                .BuildInstitution("Client")
                .BuildTrader("CitibankTrader");
        }

        public IOrderBuilder BuildCitibankDepositOrder(decimal amount)
        {
            return _orderBuilder
                .BuildTradeDate()
                .BuildCounterparty("Citibank")
                .BuildInstitution("Client")
                .BuildTrader("CitibankTrader")
                .AddMovements(
                    // Note that this creation also could be done by a MovementBuilder.
                    new List<Movement> 
                    {
                        new Movement
                        {
                            Price = amount,
                            Currency = Currency.USD
                        }
                    });
        }
    }
}
