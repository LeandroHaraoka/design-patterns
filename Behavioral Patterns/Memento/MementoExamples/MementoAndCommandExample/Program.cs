using MementoAndCommandExample.Commands;
using MementoAndCommandExample.Mementos;
using System;

namespace MementoAndCommandExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Memento");
            Console.WriteLine("Memento and Command Example");

            var originator = new Originator(1);
            var caretaker = new Caretaker(originator);
            var invoker = new Invoker();

            invoker.ExecuteCommand(new AdditionCommand(originator, caretaker, operand: 1, id: 1));
            invoker.ExecuteCommand(new MultiplicationCommand(originator, caretaker, operand: 2, id: 2));
            invoker.ExecuteCommand(new AdditionCommand(originator, caretaker, operand: 6, id: 3));
            invoker.ExecuteCommand(new MultiplicationCommand(originator, caretaker, operand: 3, id: 4));

            invoker.UndoCommand(id: 2);
            invoker.UndoCommand(id: 3);

            for (int i = 0; i <= 10; i++)
            {
                caretaker.Undo();
            }
        }
    }
}
