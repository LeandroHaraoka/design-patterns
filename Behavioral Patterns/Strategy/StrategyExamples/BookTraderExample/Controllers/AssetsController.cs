using BookTraderExample.Assets;
using BookTraderExample.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookTraderExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetsController : ControllerBase
    {
        public AssetsController()
        {
        }

        /// <summary>
        /// Books an Asset.
        /// </summary>
        /// <param name="request">Asset booking request.</param>
        /// <response code="200">Successful response.</response>
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<ActionResult<object>> Create(
            [FromBody] AssetRequest request)
        {
            #region Create Asset Chain
            var assetChainInitializerHandler = new AssetChainInitializerHandler();
            var cashAssetHandler = new CashAssetHandler();
            var bondAssetHandler = new BondAssetHandler();
            var forexAssetHandler = new ForexAssetHandler();
            var stockAssetHandler = new StockAssetHandler();
            var commodityAssetHandler = new CommodityAssetHandler();

            assetChainInitializerHandler
                .SetNext(cashAssetHandler)
                .SetNext(bondAssetHandler)
                .SetNext(forexAssetHandler)
                .SetNext(stockAssetHandler)
                .SetNext(commodityAssetHandler);
            #endregion

            assetChainInitializerHandler.Handle(request);

            return Ok();
        }
    }
}
