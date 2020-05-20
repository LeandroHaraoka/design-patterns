using StatelessExample.StateMachine;
using StatelessExample.States;
using System;
using System.Timers;

namespace StatelessExamples.States
{
    public static class DeployProduction
    {
        public static void SetupState(ActivityStateMachine machineSetup)
        {
            machineSetup._machine
                .Configure(ActivityState.DeployProduction)
                .OnEntry(t => machineSetup.ConfigureAlertTimer(3000, OnTimedEvent))
                .OnEntryFrom(Trigger.UnsuccesfulExecution, t => Console.WriteLine("Deploy Failed"))
                .OnExit(t => machineSetup._timer.Dispose())
                .Permit(Trigger.SuccesfulExecution, ActivityState.Done)
                .PermitReentry(Trigger.UnsuccesfulExecution);
        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"I need leaders to approve the ticket.");
        }
    }
}
