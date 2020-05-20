using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace StateExamples.States
{
    public class WorkInProgress : State
    {
        public WorkInProgress(Activity activity) : base(activity, 3000)
        {
        }

        public override void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"[{_activity._name}] Development should be already finished. What happened?");
        }

        public override void Execute(bool withErrors = false)
        {
            _timer.Dispose();
            _activity.ChangeState(new CodeReview(_activity));
        }
    }
}
