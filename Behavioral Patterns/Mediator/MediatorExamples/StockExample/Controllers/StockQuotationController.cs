using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockExample.Brokers;
using StockExample.StockQuotations;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace StockExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockExchangeController : ControllerBase
    {
        public readonly IMediator _newYorkStockExchange;

        public StockExchangeController(IMediator newYorkStockExchange)
        {
            _newYorkStockExchange = newYorkStockExchange;
        }

        /// <summary>
        /// Publishes a stock quotation.
        /// </summary>
        /// <param name="request">Member creation request.</param>
        /// <response code="200">Successful response.</response>
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<ActionResult<StockQuotationProposal>> PublishStockQuotation(
            [FromBody] CreateStockQuotationRequest request)
        {
            Console.WriteLine("-------------------------------------------");
            
            var notifiedQuotation = CreateQuotationPipeline
                .CreateQuotationProposal(request)
                .LogQuotationProposal()
                .PublishProposal(_newYorkStockExchange);
            
            Console.WriteLine("\n-------------------------------------------");
            
            return Ok(notifiedQuotation);
        }
    }
}
