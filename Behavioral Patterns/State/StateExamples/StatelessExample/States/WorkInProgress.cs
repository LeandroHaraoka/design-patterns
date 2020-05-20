using StatelessExample.StateMachine;
using StatelessExample.States;
using System;
using System.Timers;

namespace StatelessExamples.States
{
    public static class WorkInProgress
    {
        public static void SetupState(ActivityStateMachine machineSetup)
        {
            machineSetup._machine
                .Configure(ActivityState.WorkInProgress)
                .OnEntry(t => machineSetup.ConfigureAlertTimer(3000, OnTimedEvent))
                .OnExit(t => machineSetup._timer?.Dispose())
                .Permit(Trigger.SuccesfulExecution, ActivityState.CodeReview);
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Development should be already finished. What happened?");
        }
    }
}
