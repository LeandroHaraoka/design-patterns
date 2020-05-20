using StatelessExample.StateMachine;
using StatelessExample.States;
using System;
using System.Timers;

namespace StatelessExamples.States
{
    public static class CodeReview
    {
        public static void SetupState(ActivityStateMachine machineSetup)
        {
            machineSetup._machine
                .Configure(ActivityState.CodeReview)
                .OnEntry(t => machineSetup.ConfigureAlertTimer(3000, OnTimedEvent))
                .OnExit(t => machineSetup._timer.Dispose())
                .Permit(Trigger.SuccesfulExecution, ActivityState.DeployStaging)
                .Permit(Trigger.UnsuccesfulExecution, ActivityState.Revision);
        }
        
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"I need attention, can someone review me?");
        }
    }
}
