using MediatR;
using StockExample.Brokers;
using StockExample.StockQuotations;
using System.Linq;

namespace StockExample.Controllers
{
    public static class CreateQuotationPipeline
    {
        public static StockQuotationProposal CreateQuotationProposal(CreateStockQuotationRequest request)
        {
            var brokerName = BrokersConfiguration.Ids
                .Where(x => x.Value == request.OwnerId)
                .FirstOrDefault()
                .Key;

            return new StockQuotationProposal(request.StockShares,
                request.StockIdentifier, brokerName, request.Price, request.OwnerId, request.type);
        }

        public static StockQuotationProposal LogQuotationProposal(this StockQuotationProposal quotationProposal)
        {
            Notifications.LogQuotationProposal(quotationProposal);
            return quotationProposal;
        }

        public static BaseStockQuotation PublishProposal(this StockQuotationProposal quotationProposal,
            IMediator _newYorkStockExchange)
        {
            _newYorkStockExchange.Publish(quotationProposal).Wait();
            return quotationProposal;
        }
    }
}
