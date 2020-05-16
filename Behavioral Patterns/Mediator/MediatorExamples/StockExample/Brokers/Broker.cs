using MediatR;
using StockExample.Brokers.BrokerRepositories;
using StockExample.StockQuotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StockExample.Brokers
{
    public abstract class Broker : INotificationHandler<StockQuotation>
    {
        protected readonly Guid _id = Guid.NewGuid();
        protected string _name;
        protected readonly IMediator _newYorkStockExchange;
        private readonly BrokerRepository _brokerRepository;

        public Broker(IMediator mediator, BrokerRepository brokerRepository)
        {
            _newYorkStockExchange = mediator;
            _brokerRepository = brokerRepository;
        }

        public async Task GenerateCreateQuotation(
            int sharesQuantity, StockIdentifier stockIdentifier, decimal price, QuotationType type)
        {
            var quotation = new StockQuotation(sharesQuantity, stockIdentifier, _name, price, _id, type);

            Notifications.NotifyQuotation(quotation);

            await _newYorkStockExchange.Publish(quotation);

            if (!quotation._isExecuted)
                _brokerRepository.Add(quotation);
        }

        public async Task Handle(StockQuotation arrivedQuotation, CancellationToken cancellationToken)
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
