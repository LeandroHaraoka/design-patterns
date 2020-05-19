using System;
using System.Collections.Generic;
using System.Text;

namespace MementoAndCommandExample.Mementos
{
    public interface IMemento
    {
        double GetState();
    }

    class ConcreteMemento : IMemento
    {
        private double _state;

        public ConcreteMemento(double state) => _state = state;

        public double GetState() => _state;
    }
}
