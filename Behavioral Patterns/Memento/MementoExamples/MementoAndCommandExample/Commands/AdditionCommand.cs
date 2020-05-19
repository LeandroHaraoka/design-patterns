using MementoAndCommandExample.Mementos;
using System;

namespace MementoAndCommandExample.Commands
{
    public class AdditionCommand : Command
    {
        public AdditionCommand(Originator originator, Caretaker caretaker, double operand, int id)
            : base(originator, caretaker, operand, id)
        {
        }

        public override void Execute()
        {
            CustomConsole.WriteLine(ConsoleColor.Green, $"Executing an {nameof(AdditionCommand)}.");
            _isExecuted = true;
            _originator.Add(_operand);
            _caretaker.Backup();
        }
        public override void Undo()
        {
            CustomConsole.WriteLine(ConsoleColor.Red, $"Undoing a {nameof(AdditionCommand)}.");
            _originator.Subtract(_operand);
            _caretaker.Backup();
            _isExecuted = false;
        }
    }
}
