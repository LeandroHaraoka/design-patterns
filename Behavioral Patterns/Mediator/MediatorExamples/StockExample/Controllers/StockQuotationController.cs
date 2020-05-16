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
        /// Creates a member.
        /// </summary>
        /// <param name="request">Member creation request.</param>
        /// <response code="200">Successful response.</response>
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<ActionResult<StockQuotationNotification>> PublishStockQuotation(
            [FromBody] CreateStockQuotationRequest request)
        {
            var notifiedQuotation = CreateQuotationPipeline
                .CreateQuotationNotification(_newYorkStockExchange, request)
                .NotifyQuotation()
                .PublishQuotation(_newYorkStockExchange);

            return Ok(notifiedQuotation);
        }
    }
}
