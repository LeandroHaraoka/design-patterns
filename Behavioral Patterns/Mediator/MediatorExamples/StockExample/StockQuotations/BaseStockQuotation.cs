using MediatR;
using System;

namespace StockExample.StockQuotations
{
    public abstract class BaseStockQuotation : INotification
    {
        public readonly int _stockShares;
        public readonly StockIdentifier _stockIdentifier;
        public readonly string _ownerName;
        public readonly decimal _price;
        public readonly Guid _ownerId;
        public readonly QuotationType _type;
        public bool _isExecuted;

        public BaseStockQuotation(int stockShares, 
            StockIdentifier stockIdentifier, string ownerName, decimal price, Guid ownerId, QuotationType type)
        {
            _stockShares = stockShares;
            _stockIdentifier = stockIdentifier;
            _ownerName = ownerName;
            _price = price;
            _ownerId = ownerId;
            _type = type;
        }

        public void Execute() => _isExecuted = true;

        public bool CanGenerateTransaction(BaseStockQuotation quotation)
        {
            return _stockShares == quotation._stockShares &&
                _stockIdentifier == quotation._stockIdentifier &&
                _price == quotation._price &&
                _type != quotation._type;
        }
    }

    public class StockQuotationProposal : BaseStockQuotation
    {
        public StockQuotationProposal(
            int stockShares, StockIdentifier stockIdentifier, string ownerName, decimal price, Guid ownerId, QuotationType type) 
            : base(stockShares, stockIdentifier, ownerName, price, ownerId, type)
        {
        }
    }

    public class StockQuotation : BaseStockQuotation
    {
        public StockQuotation(StockQuotationProposal proposal)
            : base(proposal._stockShares, proposal._stockIdentifier, proposal._ownerName,
                  proposal._price, proposal._ownerId, proposal._type)
        {
        }
    }
}
