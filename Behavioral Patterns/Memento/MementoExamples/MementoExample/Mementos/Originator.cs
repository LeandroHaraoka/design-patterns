using System;

namespace Memento.Mementos
{
    public class Originator
    {
        public double _state;

        public Originator(double @base)
        {
            Console.WriteLine($"\nInitial value: {@base}\n");
            _state = @base;
        }

        public void Add(double operand)
        {
            _state += operand;
            PrintStateChange(nameof(Add), operand);
        }

        public void Subtract(double operand)
        {
            _state -= operand;
            PrintStateChange(nameof(Subtract), operand);
        }

        public void MultiplyBy(double operand)
        {
            _state *= operand;
            PrintStateChange(nameof(MultiplyBy), operand);
        }

        public void DivideBy(double operand)
        {
            _state /= operand;
            PrintStateChange(nameof(DivideBy), operand);
        }

        public IMemento Save() => new ConcreteMemento(_state);

        public void Restore(IMemento memento)
        {
            _state = memento.GetState();
            PrintStateChange(nameof(Restore), null);
        }

        private void PrintStateChange(string action, double? operand)
        {
            Console.WriteLine($"Originator Action: {action} {operand}");
            Console.WriteLine($"Result: {_state}");

        }
    }
}
