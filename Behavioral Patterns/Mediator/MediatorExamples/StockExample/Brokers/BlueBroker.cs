using MediatR;
using StockExample.Brokers.BrokerRepositories;
using System;

namespace StockExample.Brokers
{
    public class BlueBroker : Broker
    {
        public BlueBroker(IMediator mediator, BlueBrokerRepository brokerRepository)
            : base(mediator, brokerRepository, BrokersConfiguration.Ids[nameof(BlueBroker)])
        {
            _name = nameof(BlueBroker);
        }
    }
}
