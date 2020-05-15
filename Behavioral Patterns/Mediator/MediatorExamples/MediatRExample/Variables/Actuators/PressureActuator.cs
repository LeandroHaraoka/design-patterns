using MediatR;
using MediatRExample.Variables.ValueObjects;
using System;
using System.Threading.Tasks;

namespace MediatRExample.Variables.Actuators
{
    public class PressureActuator : Actuator
    {
        public PressureActuator(IMediator mediator) : base(mediator)
        {
        }

        public override async Task UpdateValue(Gas gas, ProcessType type, double value)
        {
            Console.WriteLine($"\n{nameof(PressureActuator)} Executing a {type} process, changing pressure to {value}.");
            var process = new Process(gas, new ProcessConfiguration(type, Variable.Pressure), value);
            await _mediator.Publish(process);
            PrintInfo(gas);
        }
    }
}
