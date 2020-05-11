using System.Collections.Generic;
using System.Linq;

namespace CalculatorExample.Calculators
{
    public class CalculatorManager
    {
        private readonly List<Command> _calculatorHistory = new List<Command>();
        private int _current = 0;

        public void Execute(Command operationCommand)
        {
            operationCommand.Execute();

            _calculatorHistory.RemoveFrom(_current - 1);
            _calculatorHistory.Add(operationCommand);
            _current++;
        }

        public void Undo()
        {
            if (_current > 0)
            {
                var lastCommand = _calculatorHistory[_current - 1];
                lastCommand.Undo();
                _current--;
            }
        }

        public void Redo()
        {
            if (_current < _calculatorHistory.Count)
            {
                var nextCommand = _calculatorHistory[_current];
                nextCommand.Execute();
                _current++;
            }
        }
    }
}
