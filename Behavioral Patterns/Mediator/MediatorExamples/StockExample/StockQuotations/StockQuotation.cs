using MediatR;
using System;

namespace StockExample.StockQuotations
{
    public class StockQuotation : INotification
    {
        public readonly int _stockShares;
        public readonly StockIdentifier _stockIdentifier;
        public readonly string _ownerName;
        public readonly decimal _price;
        public readonly Guid _ownerId;
        public readonly QuotationType _type;
        public bool _isExecuted;

        public StockQuotation(int stockShares, 
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

        public bool CanGenerateTransaction(StockQuotation quotation)
        {
            return _stockShares == quotation._stockShares &&
                _stockIdentifier == quotation._stockIdentifier &&
                _price == quotation._price &&
                _type != quotation._type;
        }
    }
}
