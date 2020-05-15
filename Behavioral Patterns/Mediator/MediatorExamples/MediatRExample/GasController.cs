using MediatRExample.Variables;
using MediatRExample.Variables.Actuators;
using MediatRExample.Variables.ValueObjects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MediatRExample
{
    [Route("api/gases")]
    [ApiController]
    public sealed class GasesController : ControllerBase
    {
        private readonly PressureActuator _pressureActuator;
        private readonly VolumeActuator _volumeActuator;
        private readonly TemperatureActuator _temperatureActuator;

        public GasesController(PressureActuator pressureActuator, VolumeActuator volumeActuator, TemperatureActuator temperatureActuator)
        {
            _pressureActuator = pressureActuator;
            _volumeActuator = volumeActuator;
            _temperatureActuator = temperatureActuator;
        }

        [HttpGet]
        public async Task<ActionResult> GetGases()
        {
            Console.WriteLine("Mediator");
            Console.WriteLine("Gas Example");

            var gas = new Gas(100, 10, 30);
            PrintInfo(gas);

            await _volumeActuator.UpdateValue(gas, ProcessType.Isobaric, 15);
            await _temperatureActuator.UpdateValue(gas, ProcessType.Isobaric, 90);
            await _pressureActuator.UpdateValue(gas, ProcessType.Isochoric, 10);
            await _volumeActuator.UpdateValue(gas, ProcessType.Isothermal, 60);
            await _temperatureActuator.UpdateValue(gas, ProcessType.Isochoric, 45);

            return Ok();
        }

        private void PrintInfo(Gas gas)
        {
            Console.WriteLine("Gas Info ============================================");
            Console.WriteLine($"Pressure: {gas.CurrentState.Pressure}");
            Console.WriteLine($"Volume: {gas.CurrentState.Volume}");
            Console.WriteLine($"Temperature: {gas.CurrentState.Temperature}");
        }
    }
}