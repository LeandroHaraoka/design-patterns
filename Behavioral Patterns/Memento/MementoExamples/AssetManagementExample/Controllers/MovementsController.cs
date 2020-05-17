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
    public class MovementsController : ControllerBase
    {
        private readonly IRepository<Movement> _movementRepository;
        private readonly Asset _asset;
        private readonly CareTaker _careTaker;

        // It's just an example, the repository should not be injected at application layer.
        public MovementsController(IRepository<Movement> movementRepository, Asset asset, CareTaker careTaker)
        {
            _movementRepository = movementRepository;
            _asset = asset;
            _careTaker = careTaker;
        }

        /// <summary>
        /// Create a movement.
        /// </summary>
        /// <param name="request">Movement creation request.</param>
        /// <response code="200">Successful response.</response>
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<ActionResult<Movement>> Create(
            [FromQuery] bool isRetroactive,
            [FromBody] Movement movement)
        {
            if (_asset._contract is null)
                return UnprocessableEntity();
            
            _movementRepository.Add(movement);

            if (isRetroactive)
                _careTaker.Restore(movement.TradeDate);

            return Ok(movement);
        }
    }
}
