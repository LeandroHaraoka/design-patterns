using MediatRExample.Variables.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using static MediatRExample.Variables.ValueObjects.ProcessType;
using static MediatRExample.Variables.ValueObjects.Variable;

namespace MediatRExample.Variables
{
    public class TemperatureHandler : INotificationHandler<Process>
    {
        public async Task Handle(Process request, CancellationToken cancellationToken)
        {
            request.Gas.LastState.Temperature = request.Gas.CurrentState.Temperature;

            if (request.Configuration.Type == Isothermal)
                return;

            if (request.Configuration.Variable == Temperature)
            {
                request.Gas.CurrentState.Temperature = request.Value;
                return;
            }

            var foundCalculator = _temperatureCalculator.TryGetValue(request.Configuration.Type, out var calculator);

            if (foundCalculator)
                request.Gas.CurrentState.Temperature = calculator(request.Gas, request.Value);
        }

        private static Dictionary<ProcessType, Func<Gas, double, double>> _temperatureCalculator
            = new Dictionary<ProcessType, Func<Gas, double, double>>
            {
                { Isobaric, IsobaricProcessNewPressure },
                { Isochoric, IsochoricProcessNewPressure }
            };

        private static double IsobaricProcessNewPressure(Gas gas, double newVolume) =>
            newVolume * gas.LastState.Temperature / gas.LastState.Volume;

        private static double IsochoricProcessNewPressure(Gas gas, double newPressure) =>
            newPressure * gas.LastState.Temperature / gas.LastState.Pressure;
    }
}
