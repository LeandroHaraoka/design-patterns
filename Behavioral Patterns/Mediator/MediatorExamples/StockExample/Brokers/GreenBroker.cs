using MediatR;
using StockExample.Brokers.BrokerRepositories;
using System;

namespace StockExample.Brokers
{
    public class GreenBroker : Broker
    {
        public GreenBroker(IMediator mediator, GreenBrokerRepository brokerRepository)
            : base(mediator, brokerRepository, BrokersConfiguration.Ids[nameof(GreenBroker)])
        {
            _name = nameof(GreenBroker);
        }
    }
}
