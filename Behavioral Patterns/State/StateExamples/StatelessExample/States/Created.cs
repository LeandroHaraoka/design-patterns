using StatelessExample.StateMachine;
using StatelessExample.States;
using System;
using System.Timers;

namespace StatelessExamples.States
{
    public static class Created
    {
        public static void SetupState(ActivityStateMachine machineSetup)
        {
            machineSetup._machine
                .Configure(ActivityState.Created)
                .Permit(Trigger.SuccesfulExecution, ActivityState.Todo);
        }
    }
}
