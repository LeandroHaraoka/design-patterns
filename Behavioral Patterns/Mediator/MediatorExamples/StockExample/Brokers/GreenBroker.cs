using MediatR;
using StockExample.Brokers.BrokerRepositories;

namespace StockExample.Brokers
{
    public class GreenBroker : Broker
    {
        public GreenBroker(IMediator mediator, GreenBrokerRepository brokerRepository)
            : base(mediator, brokerRepository)
        {
            _name = nameof(GreenBroker);
        }
    }
}
