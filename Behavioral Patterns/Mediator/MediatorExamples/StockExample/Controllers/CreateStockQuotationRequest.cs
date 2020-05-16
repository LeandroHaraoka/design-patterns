using StockExample.StockQuotations;
using System;

namespace StockExample.Controllers
{
    public struct CreateStockQuotationRequest
    {
        public Guid OwnerId { get; set; }
        public StockIdentifier StockIdentifier { get; set; }
        public QuotationType type { get; set; }
        public int StockShares { get; set; }
        public decimal Price { get; set; }
    }
}
