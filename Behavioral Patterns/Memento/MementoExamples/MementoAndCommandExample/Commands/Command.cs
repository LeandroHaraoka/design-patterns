using MementoAndCommandExample.Mementos;

namespace MementoAndCommandExample.Commands
{
    public abstract class Command
    {
        public readonly int _id;
        protected readonly Originator _originator;
        protected readonly Caretaker _caretaker;
        protected readonly double _operand;
        public bool _isExecuted;

        public Command(Originator originator, Caretaker caretaker, double operand, int id)
        {
            _originator = originator;
            _caretaker = caretaker;
            _operand = operand;
            _id = id;
        }

        public abstract void Execute();
        public abstract void Undo();
    }
}
