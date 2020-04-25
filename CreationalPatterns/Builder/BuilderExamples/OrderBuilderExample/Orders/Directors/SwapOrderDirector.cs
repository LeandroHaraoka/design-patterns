using OrderBuilderExample.Orders.Builders;
using OrderBuilderExample.Orders.ValueObjects;
using System.Collections.Generic;

namespace OrderBuilderExample.Orders.Directors
{
    public class SwapOrderDirector
    {
        private IOrderBuilder _orderBuilder;

        public void SetBuilder(IOrderBuilder orderBuilder)
        {
            orderBuilder.Reset();
            _orderBuilder = orderBuilder;
        }

        public IOrderBuilder BuildCreditOrder(decimal loanAmount, decimal debitAmount, Currency currency)
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
                            Price = loanAmount,
                            Direction = MovementDirection.Inflow,
                            Currency = currency
                        },
                        new Movement
                        {
                            Price = debitAmount,
                            Direction = MovementDirection.Outflow,
                            Currency = currency
                        },
                    });
        }
    }
}
