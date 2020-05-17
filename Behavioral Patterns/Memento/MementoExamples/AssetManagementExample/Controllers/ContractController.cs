using AssetManagementExample.Assets;
using AssetManagementExample.Movements;
using AssetManagementExample.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AssetManagementExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContractController : ControllerBase
    {
        private readonly Asset _asset;

        public ContractController(Asset asset)
        {
            _asset = asset;
        }

        /// <summary>
        /// Creates a contract.
        /// </summary>
        /// <param name="request">Contract creation request.</param>
        /// <response code="200">Successful response.</response>
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<ActionResult<Contract>> Create(
            [FromBody] Contract contract)
        {
            if (_asset._contract != null)
                return UnprocessableEntity();

            _asset._contract = contract;
            return Ok(contract);
        }
    }
}
