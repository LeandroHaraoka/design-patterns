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
    public class VolumeHandler : IRequestHandler<Process, Gas>
    {
        private readonly Gas _gas;

        public VolumeHandler(Gas gas) => _gas = gas;

        public async Task<Gas> Handle(Process request, CancellationToken cancellationToken)
        {
            if (request.Configuration.Type == Isochoric || request.Configuration.Variable == Volume)
                return _gas;

            var foundCalculator = _volumeCalculator.TryGetValue(request.Configuration.Type, out var calculator);

            if (foundCalculator)
                _gas.Pressure = calculator(_gas, request.Value);

            return _gas;
        }

        private static Dictionary<ProcessType, Func<Gas, double, double>> _volumeCalculator
            = new Dictionary<ProcessType, Func<Gas, double, double>>
            {
                { Isobaric, IsobaricProcessNewPressure },
                { Isothermal, IsothermalProcessNewPressure }
            };

        private static double IsobaricProcessNewPressure(Gas gas, double newTemperature) =>
            gas.Volume * newTemperature / gas.Temperature;

        private static double IsothermalProcessNewPressure(Gas gas, double newPressure) =>
            gas.Pressure * gas.Volume / newPressure;
    }
}
