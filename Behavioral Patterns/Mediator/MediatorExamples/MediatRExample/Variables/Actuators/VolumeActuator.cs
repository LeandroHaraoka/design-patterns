using MediatR;
using MediatRExample.Variables.ValueObjects;
using System;
using System.Threading.Tasks;

namespace MediatRExample.Variables.Actuators
{
    public class VolumeActuator : Actuator
    {
        public VolumeActuator(IMediator mediator) : base(mediator)
        {
        }

        public override async Task UpdateValue(Gas gas, ProcessType type, double value)
        {
            Console.WriteLine($"\n{nameof(VolumeActuator)} Executing a {type} process, changing volume to {value}.");
            var process = new Process(gas, new ProcessConfiguration(type, Variable.Volume), value);
            await _mediator.Publish(process);
            PrintInfo(gas);
        }
    }
}
