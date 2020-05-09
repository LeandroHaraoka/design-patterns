using System.Collections.Generic;
using System.Linq;

namespace CalculatorExample.Calculators
{
    public class CalculatorManager
    {
        private readonly Calculator _calculator;
        private List<Command> calculatorHistory = new List<Command>();
        private int _current = 0;

        public CalculatorManager(Calculator calculator)
        {
            _calculator = calculator;
        }
        public void Execute(Command operationCommand)
        {
            operationCommand.Execute();

            calculatorHistory.RemoveFrom(_current - 1);
            calculatorHistory.Add(operationCommand);
            _current++;
        }

        public void Undo()
        {
            if (_current > 0)
            {
                var lastCommand = calculatorHistory[_current - 1];
                lastCommand.Undo();
                _current--;
            }
        }

        public void Redo()
        {
            if (_current < calculatorHistory.Count)
            {
                var nextCommand = calculatorHistory[_current];
                nextCommand.Execute();
                _current++;
            }
        }
    }
}
