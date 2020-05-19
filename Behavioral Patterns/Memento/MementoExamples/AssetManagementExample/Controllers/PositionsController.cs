using AssetManagementExample.Accruals;
using AssetManagementExample.Assets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AssetManagementExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PositionsController : ControllerBase
    {
        private readonly IAssetManager _accrual;
        private readonly Asset _asset;
        private readonly CareTaker _careTaker;

        // It's just an example, these injections should not be at application layer.
        public PositionsController(IAssetManager accrual, Asset asset)
        {
            _accrual = accrual;
            _asset = asset;
        }

        /// <summary>
        /// Get asset position
        /// </summary>
        /// <param name="request">Asset position request.</param>
        /// <response code="200">Successful response.</response>
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<ActionResult<Asset>> Create(
            [FromQuery] DateTime date)
        {
            _accrual.UpdateStateUntil(date);

            return Ok(_asset._state);
        }
    }
}
