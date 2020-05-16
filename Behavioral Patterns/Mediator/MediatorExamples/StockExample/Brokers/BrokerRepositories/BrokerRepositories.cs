using StockExample.StockQuotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockExample.Brokers.BrokerRepositories
{
    public abstract class BrokerRepository
    {
        protected readonly IList<StockQuotation> _quotations = new List<StockQuotation>();

        public void Add(StockQuotation quotation) => _quotations.Add(quotation);
        
        public StockQuotation Find(StockQuotation quotation)
        {
            return _quotations
                .Where(q => q.CanGenerateTransaction(quotation))
                .FirstOrDefault();
        }

        public bool Remove(StockQuotation quotation) => _quotations.Remove(quotation);
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
