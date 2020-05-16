using MediatR;
using StockExample.Brokers.BrokerRepositories;
using System;

namespace StockExample.Brokers
{
    public class RedBroker : Broker
    {
        public RedBroker(IMediator mediator, RedBrokerRepository brokerRepository)
            : base(mediator, brokerRepository, BrokersConfiguration.Ids[nameof(RedBroker)])
        {
            _name = nameof(RedBroker);
        }
    }
}
