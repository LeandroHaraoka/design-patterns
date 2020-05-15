using EquationExample.Variables;
using System;

namespace EquationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mediator");
            Console.WriteLine("Equation Example");

            var gas = new Gas(100, 10, 30);
            var pressureHandler = new PressureHandler(gas);
            var temperatureHandler = new TemperatureHandler(gas);
            var volumeHandler = new VolumeHandler(gas);
        }
    }
}
