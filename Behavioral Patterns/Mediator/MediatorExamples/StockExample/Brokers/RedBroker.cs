using MediatR;
using StockExample.Brokers.BrokerRepositories;

namespace StockExample.Brokers
{
    public class RedBroker : Broker
    {
        public RedBroker(IMediator mediator, RedBrokerRepository brokerRepository)
            : base(mediator, brokerRepository)
        {
            _name = nameof(RedBroker);
        }
    }
}
