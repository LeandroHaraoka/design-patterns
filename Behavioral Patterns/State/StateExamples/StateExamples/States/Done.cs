using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace StateExamples.States
{
    public class Done : State
    {
        public Done(Activity activity) : base(activity, 0)
        {
            _timer.Dispose();
            Console.WriteLine($"[{_activity._name}] Finally delivered.");
        }

        public override void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"[{_activity._name}] I'm already done.");
        }

        public override void Execute(bool withErrors = false)
        {
        }

    }
}
