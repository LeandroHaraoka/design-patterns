using MediatRExample.Variables.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRExample.Variables
{
    public class Gas
    {
        public GasState CurrentState { get; set; }
        public GasState LastState { get; set; }

        public Gas(double pressure, double volume, double temperature)
        {
            CurrentState = new GasState(pressure, volume, temperature);
            LastState = new GasState(pressure, volume, temperature);
        }
    }

    public class GasState 
    {
        public double Pressure { get; set; }
        public double Volume { get; set; }
        public double Temperature { get; set; }

        public GasState()
        {
        }

        public GasState(double pressure, double volume, double temperature)
        {
            Pressure = pressure;
            Volume = volume;
            Temperature = temperature;
        }
    }
}
