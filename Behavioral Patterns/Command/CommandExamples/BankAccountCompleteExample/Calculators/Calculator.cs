using CalculatorExample.Calculators;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using static CalculatorExample.Calculators.MathOperation;

namespace CalculatorExample.Calculators
{
    using ReadOnlyDictionaryOfOperations = ReadOnlyDictionary<MathOperation, Func<double, double, double>>;
    using DictionaryOfOperations = Dictionary<MathOperation, Func<double, double, double>>;

    public class Calculator
    {
        private double _cachedValue = 0;

        public void Operation(MathOperation operation, double value)
        {
            var foundOperation = MathOperations.TryGetValue(operation, out var operationFunc);

            if (foundOperation)
            {
                _cachedValue = operationFunc(_cachedValue, value);
                Console.WriteLine($"Current value = {_cachedValue} (last operation: {operation} {value})");
            }
        }

        public static ReadOnlyDictionaryOfOperations MathOperations =
            new ReadOnlyDictionaryOfOperations(
                new DictionaryOfOperations
                {
                    { Add, (first, second) => first + second },
                    { Subtract, (first, second) => first - second},
                    { Multiply, (first, second) =>  first * second },
                    { Divide, (first, second) =>  first / second}
                });
    }
}
