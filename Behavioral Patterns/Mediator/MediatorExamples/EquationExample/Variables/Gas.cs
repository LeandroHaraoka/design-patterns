using EquationExample.Variables.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquationExample.Variables
{
    public class Gas
    {
        public Gas(double pressure, double volume, double temperature)
        {
            Pressure = pressure;
            Volume = volume;
            Temperature = temperature;
        }

        public double Pressure { get; set; }
        public double Volume { get; set; }
        public double Temperature { get; set; }
    }
}
