using MediatR;
using StockExample.Brokers.BrokerRepositories;
using StockExample.StockQuotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StockExample.Brokers
{
    public abstract class Broker : INotificationHandler<StockQuotationNotification>
    {
        public readonly Guid _id;
        protected string _name;
        protected readonly IMediator _newYorkStockExchange;
        private readonly BrokerRepository _brokerRepository;

        public Broker(IMediator mediator, BrokerRepository brokerRepository, Guid brokerId)
        {
            _newYorkStockExchange = mediator;
            _brokerRepository = brokerRepository;
            _id = brokerId;
        }

        public async Task Handle(StockQuotationNotification arrivedQuotation, CancellationToken cancellationToken)
        {
            if (arrivedQuotation._ownerId == _id || arrivedQuotation._isExecuted)
                return;

            var myQuotation = _brokerRepository.Find(arrivedQuotation);

            if (myQuotation is null)
                return;

            arrivedQuotation._isExecuted = true;
            _brokerRepository.Remove(myQuotation);

            Notifications.NotifyTransaction(myQuotation, arrivedQuotation);
        }
    }
}
