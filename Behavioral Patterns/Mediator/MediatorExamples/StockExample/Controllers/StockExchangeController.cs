using Microsoft.AspNetCore.Mvc;
using StockExample.Brokers;
using StockExample.StockQuotations;
using System;
using System.Threading.Tasks;

namespace StockExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockExchangeController : ControllerBase
    {
        private readonly BlueBroker _blueBroker;
        private readonly GreenBroker _greenBroker;
        private readonly RedBroker _redBroker;

        public StockExchangeController(BlueBroker blueBroker, GreenBroker greenBroker, RedBroker redBroker)
        {
            _blueBroker = blueBroker;
            _greenBroker = greenBroker;
            _redBroker = redBroker;
        }

        [HttpGet]
        public async Task<ActionResult> GetGases()
        {
            Console.WriteLine("Mediator");
            Console.WriteLine("Stock Exchange Example");

            await _blueBroker.GenerateCreateQuotation(300, StockIdentifier.FB, 10m, QuotationType.Bid);
            await _redBroker.GenerateCreateQuotation(150, StockIdentifier.GOOG, 20m, QuotationType.Bid);
            await _greenBroker.GenerateCreateQuotation(100, StockIdentifier.MSFT34, 50m, QuotationType.Bid);

            await Task.Delay(3000);

            await _blueBroker.GenerateCreateQuotation(100, StockIdentifier.MSFT34, 50m, QuotationType.Ask);
            await _redBroker.GenerateCreateQuotation(300, StockIdentifier.FB, 10m, QuotationType.Ask);
            await _greenBroker.GenerateCreateQuotation(150, StockIdentifier.GOOG, 20m, QuotationType.Ask);
            
            return Ok();
        }
    }
}
