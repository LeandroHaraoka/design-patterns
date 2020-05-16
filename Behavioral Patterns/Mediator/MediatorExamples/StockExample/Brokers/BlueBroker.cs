using MediatR;
using StockExample.Brokers.BrokerRepositories;

namespace StockExample.Brokers
{
    public class BlueBroker : Broker
    {
        public BlueBroker(IMediator mediator, BlueBrokerRepository brokerRepository)
            : base(mediator, brokerRepository)
        {
            _name = nameof(BlueBroker);
        }
    }
}
