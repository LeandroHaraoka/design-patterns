using CalculatorExample.Calculators;
using System;
using static CalculatorExample.Calculators.MathOperation;

namespace CalculatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Command");
            Console.WriteLine("Calculator Example");

            var calculator = new Calculator();
            var calculatorManager = new CalculatorManager(calculator);

            calculatorManager.Execute(new CalculatorOperation(calculator, Add, 1000));
            calculatorManager.Execute(new CalculatorOperation(calculator, Subtract, 200));
            calculatorManager.Execute(new CalculatorOperation(calculator, Multiply, 2));
            calculatorManager.Execute(new CalculatorOperation(calculator, Divide, 4));

            calculatorManager.Undo();
            calculatorManager.Undo();
            calculatorManager.Execute(new CalculatorOperation(calculator, Multiply, 3));
            calculatorManager.Execute(new CalculatorOperation(calculator, Divide, 5));
            calculatorManager.Undo();
            calculatorManager.Redo();

        }
    }
}
