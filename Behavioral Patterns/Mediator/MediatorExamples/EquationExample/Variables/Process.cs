using EquationExample.Variables.ValueObjects;
using MediatR;

namespace EquationExample.Variables
{
    public class Process : IRequest<Gas>
    {
        public ProcessConfiguration Configuration { get; set; }
        public double Value { get; set; }

        public Process(ProcessConfiguration configuration, double value)
        {
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
