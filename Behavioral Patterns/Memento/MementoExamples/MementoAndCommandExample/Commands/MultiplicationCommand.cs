using MementoAndCommandExample.Mementos;
using System;

namespace MementoAndCommandExample.Commands
{
    public class MultiplicationCommand : Command
    {
        public MultiplicationCommand(Originator originator, Caretaker caretaker, double operand, int id)
            : base(originator, caretaker, operand, id)
        {
        }

        public override void Execute()
        {
            CustomConsole.WriteLine(ConsoleColor.Green, $"Executing a {nameof(MultiplicationCommand)}.");
            _isExecuted = true;
            _originator.MultiplyBy(_operand);
            _caretaker.Backup();
        }
        public override void Undo()
        {
            CustomConsole.WriteLine(ConsoleColor.Red, $"Undoing a {nameof(MultiplicationCommand)}.");
            _originator.DivideBy(_operand);
            _caretaker.Backup();
            _isExecuted = false;
        }
    }
}
