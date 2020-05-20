using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace StateExamples.States
{
    public class Revision : State
    {
        public Revision(Activity activity) : base(activity, 3000)
        {
        }

        public override void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"[{_activity._name}] Errors were already pointed, will you correct them or not?");
        }

        public override void Execute(bool withErrors = false)
        {
            _timer.Dispose();
            _activity.ChangeState(new DeployStaging(_activity));
        }
    }
}
