using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using static CalculatorExample.Calculators.MathOperation;

namespace CalculatorExample.Calculators
{
    public class CalculatorOperation : Command
    {
        private MathOperation _operation;
        private double _operand;
        private Calculator _calculator;

        public CalculatorOperation(Calculator calculator, MathOperation operation, double operand)
        {
            _calculator = calculator;
            _operation = operation;
            _operand = operand;
        }

        public override void Execute()
        {
            _calculator.Operation(_operation, _operand);
        }

        public override void Undo()
        {
            var oppositeOperation = OppositeOperations[_operation];

            _calculator.Operation(oppositeOperation, _operand);
        }

        private static ReadOnlyDictionary<MathOperation, MathOperation> OppositeOperations =
            new ReadOnlyDictionary<MathOperation, MathOperation>(
                new Dictionary<MathOperation, MathOperation>
                {
                    { Add, Subtract },
                    { Subtract, Add },
                    { Multiply, Divide },
                    { Divide, Multiply },
                });
    }
}
