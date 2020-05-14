using MediatRExample.Variables.ValueObjects;
using MediatR;

namespace MediatRExample.Variables
{
    public class Process : INotification
    {
        public Gas Gas { get; set; }
        public ProcessConfiguration Configuration { get; set; }
        public double Value { get; set; }

        public Process(Gas gas, ProcessConfiguration configuration, double value)
        {
            Gas = gas;
            Configuration = configuration;
            Value = value;
        }
    }

    public struct ProcessConfiguration
    {
        public ProcessType Type { get; set; }
        public Variable Variable { get; set; }
  
        public ProcessConfiguration(ProcessType type, Variable variable)
        {
            Type = type;
            Variable = variable;
        }
    }
}
