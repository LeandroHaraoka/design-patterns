using StateExamples.States;
using System;
using System.Threading;

namespace StateExamples
{
    public class Activity
    {
        public readonly string _name;
        private State _state;

        public Activity(string name)
        {
            _name = name;
            ChangeState(new Todo(this));
        }

        public void ChangeState(State state)
        {
            _state = state;
            _state.InitializeAlertTimer();
            Print($" New Status: {_state.GetType().Name}");
        }

        public void ExecuteCurrentTask(int elapsedTime, bool withErrors = false)
        {
            Thread.Sleep(elapsedTime);
            _state.Execute(withErrors);
        }

        private void Print(string stateChangeMessage)
        {
            Console.Write($"[{_name}]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(stateChangeMessage);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
