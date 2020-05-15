using EquationExample.Variables.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using static EquationExample.Variables.ValueObjects.ProcessType;
using static EquationExample.Variables.ValueObjects.Variable;

namespace EquationExample.Variables
{
    public class PressureHandler : IRequestHandler<Process, Gas>
    {
        private readonly Gas _gas;

        public PressureHandler(Gas gas) => _gas = gas;

        public async Task<Gas> Handle(Process request, CancellationToken cancellationToken)
        {
            if (request.Configuration.Type == Isobaric || request.Configuration.Variable == Pressure)
                return _gas;

            var foundCalculator = _pressureCalculator.TryGetValue(request.Configuration.Type, out var calculator);

            if (foundCalculator)
                _gas.Pressure = calculator(_gas, request.Value);

            return _gas;
        }

        private static Dictionary<ProcessType, Func<Gas, double, double>> _pressureCalculator
            = new Dictionary<ProcessType, Func<Gas, double, double>>
            {
                { Isochoric, IsochoricProcessNewPressure },
                { Isothermal, IsothermalProcessNewPressure }
            };

        private static double IsochoricProcessNewPressure(Gas gas, double newTemperature) =>
            gas.Pressure * newTemperature / gas.Temperature;
        
        private static double IsothermalProcessNewPressure(Gas gas, double newVolume) =>
            gas.Pressure * gas.Volume / newVolume;
    }
}
