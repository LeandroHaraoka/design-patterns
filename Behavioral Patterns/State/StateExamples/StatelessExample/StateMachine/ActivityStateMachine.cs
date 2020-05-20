using Stateless;
using Stateless.Graph;
using StatelessExample.StateMachine;
using StatelessExamples;
using StatelessExamples.States;
using System;
using System.Timers;

namespace StatelessExample.States
{
    public class ActivityStateMachine
    {
        public readonly StateMachine<ActivityState, Trigger> _machine;
        public Timer _timer;
        public Activity _activity;

        public ActivityStateMachine(Activity activity)
        {
            _activity = activity;
            _machine = new StateMachine<ActivityState, Trigger>(() => _activity._state, s => _activity._state = s);

            _machine.OnTransitioned(
                (StateMachine<ActivityState, Trigger>.Transition transition)
                    => Print($" New Status: {_activity._state}"));

            Created.SetupState(this);
            Todo.SetupState(this);
            WorkInProgress.SetupState(this);
            CodeReview.SetupState(this);
            Revision.SetupState(this);
            DeployStaging.SetupState(this);
            BusinessValidation.SetupState(this);
            DeployProduction.SetupState(this);
        }

        public void ConfigureAlertTimer(double alertInterval, ElapsedEventHandler onTimedEvent)
        {
            if (alertInterval <= 0)
                return;

            _timer = new Timer(alertInterval)
            {
                AutoReset = true,
            };

            _timer.Elapsed += onTimedEvent;
            _timer.Start();
        }

        private void Print(string stateChangeMessage)
        {
            Console.Write($"[{_activity._name}] ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(stateChangeMessage);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Fire(Trigger trigger) => _machine.Fire(trigger);
        public void PrintUmlDotGraph()
        {
            string graph = UmlDotGraph.Format(_machine.GetInfo());
            Console.WriteLine("UmlDotGraph:");
            Console.WriteLine(graph);
        }
    }
}
