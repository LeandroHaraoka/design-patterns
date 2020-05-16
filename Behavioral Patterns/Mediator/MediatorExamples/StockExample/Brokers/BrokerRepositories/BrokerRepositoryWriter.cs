using MediatR;
using StockExample.StockQuotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StockExample.Brokers.BrokerRepositories
{
    public abstract class BrokerRepositoryWriter : INotificationHandler<StockQuotationDocument>
    {
        protected Guid _brokerId;
        private readonly BrokerRepository _brokerRepository;

        public BrokerRepositoryWriter(BrokerRepository brokerRepository)
        {
            _brokerRepository = brokerRepository;
        }

        public async Task Handle(StockQuotationDocument quotationDocument, CancellationToken cancellationToken)
        {
            if (quotationDocument._ownerId != _brokerId)
                return;

            _brokerRepository.Add(quotationDocument);
        }
    }

    public class BlueBrokerRepositoryWriter : BrokerRepositoryWriter
    {
        public BlueBrokerRepositoryWriter(BlueBrokerRepository brokerRepository, BlueBroker blueBroker)
            : base(brokerRepository)
        {
            _brokerId = blueBroker._id;
        }
    }

    public class RedBrokerRepositoryWriter : BrokerRepositoryWriter
    {
        public RedBrokerRepositoryWriter(RedBrokerRepository brokerRepository, RedBroker redBroker)
            : base(brokerRepository)
        {
            _brokerId = redBroker._id;
        }
    }

    public class GreenBrokerRepositoryWriter : BrokerRepositoryWriter
    {
        public GreenBrokerRepositoryWriter(GreenBrokerRepository brokerRepository, GreenBroker greenBroker)
            : base(brokerRepository)
        {
            _brokerId = greenBroker._id;
        }
    }
}
