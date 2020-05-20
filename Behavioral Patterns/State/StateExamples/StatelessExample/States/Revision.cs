using StatelessExample.StateMachine;
using StatelessExample.States;
using System;
using System.Timers;

namespace StatelessExamples.States
{
    public static class Revision
    {
        public static void SetupState(ActivityStateMachine machineSetup)
        {
            machineSetup._machine
                .Configure(ActivityState.Revision)
                .OnEntry(t => machineSetup.ConfigureAlertTimer(3000, OnTimedEvent))
                .OnExit(t => machineSetup._timer.Dispose())
                .Permit(Trigger.SuccesfulExecution, ActivityState.DeployStaging);
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Errors were already pointed, will you correct them or not?");
        }
    }
}
