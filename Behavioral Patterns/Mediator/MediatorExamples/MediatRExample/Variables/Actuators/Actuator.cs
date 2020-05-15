using MediatR;
using MediatRExample.Variables.ValueObjects;
using System;
using System.Threading.Tasks;

namespace MediatRExample.Variables.Actuators
{
    public abstract class Actuator
    {
        protected readonly IMediator _mediator;

        public Actuator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract Task UpdateValue(Gas gas, ProcessType type, double value);

        protected void PrintInfo(Gas gas)
        {
            Console.WriteLine("Gas Info ============================================");
            Console.WriteLine($"Pressure: {gas.CurrentState.Pressure}");
            Console.WriteLine($"Volume: {gas.CurrentState.Volume}");
            Console.WriteLine($"Temperature: {gas.CurrentState.Temperature}");
        }
    }
}
