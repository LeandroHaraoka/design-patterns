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
    public class PressureHandler : INotificationHandler<Process>
    {
        public async Task Handle(Process request, CancellationToken cancellationToken)
        {
            request.Gas.LastState.Pressure = request.Gas.CurrentState.Pressure;

            if (request.Configuration.Type == Isobaric)
                return;

            if (request.Configuration.Variable == Pressure)
            {
                request.Gas.CurrentState.Pressure = request.Value;
                return;
            }

            var foundCalculator = _pressureCalculator.TryGetValue(request.Configuration.Type, out var calculator);

            if (foundCalculator)
                request.Gas.CurrentState.Pressure = calculator(request.Gas, request.Value);
        }

        private static Dictionary<ProcessType, Func<Gas, double, double>> _pressureCalculator
            = new Dictionary<ProcessType, Func<Gas, double, double>>
            {
                { Isochoric, IsochoricProcessNewPressure },
                { Isothermal, IsothermalProcessNewPressure }
            };

        private static double IsochoricProcessNewPressure(Gas gas, double newTemperature) =>
            gas.LastState.Pressure * newTemperature / gas.LastState.Temperature;

        private static double IsothermalProcessNewPressure(Gas gas, double newVolume) =>
            gas.LastState.Pressure * gas.LastState.Volume / newVolume;
    }
}
