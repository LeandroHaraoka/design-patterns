using MediatR;
using StockExample.Brokers;
using StockExample.StockQuotations;
using System.Linq;

namespace StockExample.Controllers
{
    public static class CreateQuotationPipeline
    {
        public static StockQuotationNotification CreateQuotationNotification(IMediator _newYorkStockExchange,
            CreateStockQuotationRequest request)
        {
            var brokerName = BrokersConfiguration.Ids
                .Where(x => x.Value == request.OwnerId)
                .FirstOrDefault()
                .Key;

            return new StockQuotationNotification(request.StockShares,
                request.StockIdentifier, brokerName, request.Price, request.OwnerId, request.type);
        }
        public static StockQuotationNotification NotifyQuotation(this StockQuotationNotification quotationNotification)
        {
            Notifications.NotifyQuotation(quotationNotification);
            return quotationNotification;
        }

        public static StockQuotationNotification PublishQuotation(this StockQuotationNotification quotationNotification,
            IMediator _newYorkStockExchange)
        {
            _newYorkStockExchange.Publish(quotationNotification).Wait();

            if (!quotationNotification._isExecuted)
            {
                var quotationDocument = new StockQuotationDocument(quotationNotification);
                _newYorkStockExchange.Publish(quotationDocument).Wait();
            }

            return quotationNotification;
        }
    }
}
