using StatelessExample.StateMachine;
using StatelessExample.States;
using System;
using System.Timers;

namespace StatelessExamples.States
{
    public static class DeployStaging
    {
        public static void SetupState(ActivityStateMachine machineSetup)
        {
            machineSetup._machine
                .Configure(ActivityState.DeployStaging)
                .OnEntry(t => machineSetup.ConfigureAlertTimer(3000, OnTimedEvent))
                .OnExit(t => machineSetup._timer.Dispose())
                .Permit(Trigger.SuccesfulExecution, ActivityState.BusinessValidation);
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"Deploy to staging is taking longer than normal..");
        }
    }
}
