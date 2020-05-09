using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorExample.Calculators
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}
