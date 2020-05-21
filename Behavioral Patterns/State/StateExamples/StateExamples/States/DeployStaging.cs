using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace StateExamples.States
{
    public class DeployStaging : State
    {
        public DeployStaging(Activity activity) : base(activity, 1000)
        {
        }

        public override void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"[{_activity._name}] Deploy to staging is taking longer than normal..");
        }

        public override void Execute(bool withErrors = false)
        {
            _timer.Dispose();
            _activity.ChangeState(new BusinessValidation(_activity));
        }
    }
}
