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
    public class TemperatureHandler : IRequestHandler<Process, Gas>
    {
        private readonly Gas _gas;

        public TemperatureHandler(Gas gas) => _gas = gas;

        public async Task<Gas> Handle(Process request, CancellationToken cancellationToken)
        {
            if (request.Configuration.Type == Isothermal || request.Configuration.Variable == Temperature)
                return _gas;

            var foundCalculator = _temperatureCalculator.TryGetValue(request.Configuration.Type, out var calculator);

            if (foundCalculator)
                _gas.Pressure = calculator(_gas, request.Value);

            return _gas;
        }

        private static Dictionary<ProcessType, Func<Gas, double, double>> _temperatureCalculator
            = new Dictionary<ProcessType, Func<Gas, double, double>>
            {
                { Isobaric, IsobaricProcessNewPressure },
                { Isochoric, IsochoricProcessNewPressure }
            };

        private static double IsobaricProcessNewPressure(Gas gas, double newVolume) =>
            newVolume * gas.Temperature / gas.Volume;

        private static double IsochoricProcessNewPressure(Gas gas, double newPressure) =>
            newPressure * gas.Temperature / gas.Pressure;
    }
}
