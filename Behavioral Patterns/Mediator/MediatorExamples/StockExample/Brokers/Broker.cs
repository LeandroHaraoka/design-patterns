using MediatR;
using StockExample.Brokers.BrokerRepositories;
using StockExample.StockQuotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StockExample.Brokers
{
    public abstract class Broker : INotificationHandler<StockQuotationProposal>, INotificationHandler<StockQuotation>
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

        // Approve proposal (check risk, bank balance, etc)
        public async Task Handle(StockQuotationProposal arrivedProposal, CancellationToken cancellationToken)
        {
            if (arrivedProposal._ownerId != _id)
                return;

            // Instructions to approve proposal

            var stockQuotation = new StockQuotation(arrivedProposal);
            _newYorkStockExchange.Publish(stockQuotation).Wait();

            if (!stockQuotation._isExecuted)
                _brokerRepository.Add(stockQuotation);
        }

        public async Task Handle(StockQuotation arrivedQuotation, CancellationToken cancellationToken)
        {
            if (arrivedQuotation._ownerId == _id || arrivedQuotation._isExecuted)
                return;

            var myOffer = _brokerRepository.FindOffer(arrivedQuotation);

            if (myOffer is null)
                return;

            arrivedQuotation._isExecuted = true;
            Notifications.NotifyTransaction(myOffer, arrivedQuotation);
            
            _brokerRepository.Remove(myOffer);
        }
    }
}
