using StatelessExample.StateMachine;
using StatelessExample.States;

namespace StatelessExamples
{
    public class Activity
    {
        public readonly string _name;
        private readonly ActivityStateMachine _machine;
        public ActivityState _state = ActivityState.Created;

        public Activity(string name)
        {
            _name = name;
            _machine = new ActivityStateMachine(this);
        }

        public void ExecuteTasksWithSuccess() 
        {
            System.Threading.Thread.Sleep(8000);
            _machine.Fire(Trigger.SuccesfulExecution);
        }

        public void ExecuteTasksWithErrors()
        {
            System.Threading.Thread.Sleep(8000);
            _machine.Fire(Trigger.UnsuccesfulExecution);
        }

        public void PrintUmlDotGraph() => _machine.PrintUmlDotGraph();
    }
}
