using StockExample.StockQuotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockExample.Brokers.BrokerRepositories
{
    public abstract class BrokerRepository
    {
        protected readonly IList<BaseStockQuotation> _quotations = new List<BaseStockQuotation>();

        public void Add(BaseStockQuotation quotation) => _quotations.Add(quotation);
        
        public BaseStockQuotation FindOffer(BaseStockQuotation quotation)
        {
            return _quotations
                .Where(q => q.CanGenerateTransaction(quotation))
                .FirstOrDefault();
        }

        public bool Remove(BaseStockQuotation quotation) => _quotations.Remove(quotation);
    }

    public class BlueBrokerRepository : BrokerRepository
    {
    }

    public class RedBrokerRepository : BrokerRepository
    {
    }

    public class GreenBrokerRepository : BrokerRepository
    {
    }
}
