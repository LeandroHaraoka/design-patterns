using EquationExample.Variables;
using EquationExample.Variables.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquationExample
{
    public class GasesProcessor
    {
        private readonly IMediator _mediator;

        public GasesProcessor(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void ExecuteThermodynamicProcess(Gas gas, ProcessType type, Variable variable, double value)
        {
            var process = new Process(new ProcessConfiguration(type, variable), value);

            _mediator.Send(process);
        }
    }
}
