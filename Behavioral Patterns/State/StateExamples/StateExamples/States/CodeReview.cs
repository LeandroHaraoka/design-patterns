using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace StateExamples.States
{
    public class CodeReview : State
    {
        public CodeReview(Activity activity) : base(activity, 1000)
        {
        }

        public override void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"[{_activity._name}] I need attention, can someone review me?");
        }

        public override void Execute(bool withErrors = false)
        {
            _timer.Dispose();

            if (withErrors)
            {
                _activity.ChangeState(new Revision(_activity));
                return;
            }

            _activity.ChangeState(new DeployStaging(_activity));
        }
    }
}
