using MediatR;
using MediatRExample.Variables.ValueObjects;
using System;
using System.Threading.Tasks;

namespace MediatRExample.Variables.Actuators
{
    public class TemperatureActuator : Actuator
    {
        public TemperatureActuator(IMediator mediator) : base(mediator)
        {
        }

        public override async Task UpdateValue(Gas gas, ProcessType type, double value)
        {
            Console.WriteLine($"\n{nameof(TemperatureActuator)} Executing a {type} process, changing temperature to {value}.");
            var process = new Process(gas, new ProcessConfiguration(type, Variable.Temperature), value);
            await _mediator.Publish(process);
            PrintInfo(gas);
        }
    }
}
