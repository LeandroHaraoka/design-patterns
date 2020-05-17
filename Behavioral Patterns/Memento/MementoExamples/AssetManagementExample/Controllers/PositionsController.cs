using AssetManagementExample.Accruals;
using AssetManagementExample.Assets;
using AssetManagementExample.Movements;
using AssetManagementExample.Repositories;
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
        private readonly Accrual _accrual;
        private readonly Asset _asset;
        private readonly CareTaker _careTaker;

        // It's just an example, the repository should not be injected at application layer.
        public PositionsController(Accrual accrual, Asset asset, CareTaker careTaker)
        {
            _accrual = accrual;
            _asset = asset;
            _careTaker = careTaker;
        }

        /// <summary>
        /// Get asset position
        /// </summary>
        /// <param name="request">Member creation request.</param>
        /// <response code="200">Successful response.</response>
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<ActionResult<AssetState>> Create(
            [FromQuery] DateTime date)
        {
            _accrual.ExecuteUntil(date, _asset, _careTaker);

            return Ok(_asset._state);
        }
    }
}
