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
    public class VolumeHandler : INotificationHandler<Process>
    {
        public async Task Handle(Process request, CancellationToken cancellationToken)
        {
            request.Gas.LastState.Volume = request.Gas.CurrentState.Volume;

            if (request.Configuration.Type == Isochoric)
                return;

            if (request.Configuration.Variable == Volume)
            {
                request.Gas.CurrentState.Volume = request.Value;
                return;
            }

            var foundCalculator = _volumeCalculator.TryGetValue(request.Configuration.Type, out var calculator);

            if (foundCalculator)
                request.Gas.CurrentState.Volume = calculator(request.Gas, request.Value);
        }

        private static Dictionary<ProcessType, Func<Gas, double, double>> _volumeCalculator
            = new Dictionary<ProcessType, Func<Gas, double, double>>
            {
                { Isobaric, IsobaricProcessNewPressure },
                { Isothermal, IsothermalProcessNewPressure }
            };

        private static double IsobaricProcessNewPressure(Gas gas, double newTemperature) =>
            gas.LastState.Volume * newTemperature / gas.LastState.Temperature;

        private static double IsothermalProcessNewPressure(Gas gas, double newPressure) =>
            gas.LastState.Pressure * gas.LastState.Volume / newPressure;
    }
}
