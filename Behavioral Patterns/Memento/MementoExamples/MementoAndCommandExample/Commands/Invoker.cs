using System.Collections.Generic;
using System.Linq;

namespace MementoAndCommandExample.Commands
{
    public class Invoker
    {
        public readonly IList<Command> _commands = new List<Command>();

        public void ExecuteCommand(Command command)
        {
            _commands.Add(command);
            command.Execute();
        }

        public void UndoCommand(int id)
        {
            var command = _commands.Where(x => x._id == id).Single();

            if (!command._isExecuted)
                return;

            command.Undo();
        }
    }
}
