using MediatR;
using MediatRExample.Variables;
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
        private readonly IMediator _mediator;

        public GasesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetGases()
        {
            Console.WriteLine("Mediator");
            Console.WriteLine("Equation Example");

            var gas = new Gas(100, 10, 30);
            PrintInfo(gas);

            
            await ExecuteProcess(ProcessType.Isobaric, Variable.Volume, 15);
            await ExecuteProcess(ProcessType.Isobaric, Variable.Temperature, 90);
            await ExecuteProcess(ProcessType.Isochoric, Variable.Pressure, 10);
            await ExecuteProcess(ProcessType.Isothermal, Variable.Volume, 60);
            await ExecuteProcess(ProcessType.Isochoric, Variable.Temperature, 45);

            return Ok();

            async Task ExecuteProcess(ProcessType type, Variable variable, double value)
            {
                Console.WriteLine($"\nExecuting a {type} process, changing the {variable} to {value}");
                var process = new Process(gas, new ProcessConfiguration(type, variable), value);
                await _mediator.Publish(process);
                PrintInfo(gas);
            }
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